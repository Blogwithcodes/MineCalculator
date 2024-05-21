﻿using DesktopApp.Model;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using DocumentFormat.OpenXml.Spreadsheet;

namespace DesktopApp.UserControls
{

    public partial class MineFieldLayoutControl : UserControl
    {
        SharedDataModel sharedDataModel = new SharedDataModel();
        bool IsEditMode = false;
        int RowIndex = -1;
        Dictionary<string, Point> pointsDictionary = new Dictionary<string, Point>();

        public MineFieldLayoutControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;

            InitializeComponent();

            InitializeDataGridView();
        }
        public void InitCalculate()
        {
            AddDropDownOptions();

            //TESTING PURPUSE 
            distanceFrom_dropdown.SelectedIndex = 1;
            distanceTo_dropdown.SelectedIndex = 2;
            distance_tb.Text = "100";
            grOf_tb.Text = "ssm1";
            Bearing_tb.Text = "100";


        }

        private void AddDropDownOptions()
        {
            //Remove Items if present 
            distanceFrom_dropdown.Items.Clear();
            distanceTo_dropdown.Items.Clear();
            // Add LandMark 
            distanceFrom_dropdown.Items.Add("Landmark");
            distanceTo_dropdown.Items.Add("Landmark");

            //Add SSM 
            for (int i = 0; i < sharedDataModel.Assumed_strips; i++)
            {
                distanceFrom_dropdown.Items.Add("SSM_" + (i + 1));
                distanceTo_dropdown.Items.Add("SSM_" + (i + 1));
            }
            //Add ESM 
            for (int i = 0; i < sharedDataModel.Assumed_strips; i++)
            {
                distanceFrom_dropdown.Items.Add("ESM_" + (i + 1));
                distanceTo_dropdown.Items.Add("ESM_" + (i + 1));
            }
            //Add TP
            for (int i = 0; i < 10; i++)
            {
                distanceFrom_dropdown.Items.Add("TP_" + (i + 1));
                distanceTo_dropdown.Items.Add("TP_" + (i + 1));
            }
        }
        private void InitializeDataGridView()
        {
            // Define columns



            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Distance From";
            column1.Name = "DistanceFrom";
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Distance To";
            column2.Name = "DistanceTo";
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Distance ";
            column3.Name = "Distance";
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(column3);
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "G Ref ";
            column4.Name = "GRef";
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(column4);

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.HeaderText = "Bearing";
            column5.Name = "Bearing";
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(column5);


            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "editColumn";
            editColumn.HeaderText = "";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "DeleteColumn";
            deleteColumn.HeaderText = "";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(deleteColumn);

            // add delegate for click event 
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;

            // Customize cell styles
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Enable sorting
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            // Add alternate row styles
            dataGridView1.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            // Customize column header styles
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.Columns["editColumn"].DefaultCellStyle.BackColor = System.Drawing.Color.ForestGreen;
            dataGridView1.Columns["editColumn"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen;

            dataGridView1.Columns["DeleteColumn"].DefaultCellStyle.BackColor = System.Drawing.Color.RosyBrown;
            dataGridView1.Columns["DeleteColumn"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;




        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on the icon column and not on the header
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["editColumn"].Index)
            {
                RowIndex = e.RowIndex;
                dataGridTabelColumns rowdata = GetRowData(e.RowIndex);
                if (rowdata != null) EditData(rowdata);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index)
            {
                string message = (IsEditMode) ? "Edit Mode is on. Do you want to off edit mode and delete that data" : "Are you sure you want to delete.";
                DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    if (IsEditMode)
                    {
                        ToggleEditMode(false);
                    }
                }
            }

        }
        private dataGridTabelColumns GetRowData(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                // Access cell values from the row
                dataGridTabelColumns rowData = new dataGridTabelColumns();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i == 0)
                    {
                        rowData.DistanceFrom = row.Cells[i].Value.ToString();
                    }
                    if (i == 1)
                    {
                        rowData.DistanceTo = row.Cells[i].Value.ToString();
                    }
                    if (i == 2)
                    {
                        rowData.Distance = row.Cells[i].Value.ToString();
                    }
                    if (i == 3)
                    {
                        rowData.GRef = row.Cells[i].Value.ToString();
                    }
                    if (i == 4)
                    {
                        rowData.Bearing = row.Cells[i].Value.ToString();
                    }
                }

                return rowData;
            }
            return null;
        }

        private void EditData(dataGridTabelColumns rowdata)
        {
            distanceFrom_dropdown.Text = rowdata.DistanceFrom;
            distanceTo_dropdown.Text = rowdata.DistanceTo;
            distance_tb.Text = rowdata.Distance;
            grOf_tb.Text = rowdata.GRef;
            Bearing_tb.Text = rowdata.Bearing;

            ToggleEditMode(true);
        }
        private void ToggleEditMode(bool Isedit)
        {


            if (Isedit)
            {
                savebtn.Text = "Edit Data";
                editPanel.BackColor = System.Drawing.Color.DodgerBlue;

                dataGridView1.Rows[RowIndex].Selected = true;
                if (Isedit != IsEditMode)
                { MessageBox.Show("Edit Mode Activated", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                IsEditMode = true;
            }
            else
            {
                savebtn.Text = "Add To table";
                editPanel.BackColor = System.Drawing.Color.Transparent;
                IsEditMode = false;
                RowIndex = -1;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[RowIndex].Selected = true;
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string ValidityResponse = ValidateData();

            if (ValidityResponse != "NOERROR")
            {
                SetErrorProviderComboBox(distanceTo_dropdown);
                SetErrorProviderComboBox(distanceFrom_dropdown);
                SetErrorProviderTextBox(distance_tb);
                SetErrorProviderTextBox(grOf_tb, false);
                SetErrorProviderTextBox(Bearing_tb);


                MessageBox.Show(ValidityResponse, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!IsEditMode)
            {
                //Add data to datagrid 
                string[] rowData = { distanceFrom_dropdown.Text, distanceTo_dropdown.Text, distance_tb.Text, grOf_tb.Text, Bearing_tb.Text };
                // Add a new row to the DataGridView and set its values
                dataGridView1.Rows.Add(rowData);
            }
            else
            {

                EditRowValues(RowIndex);
                ToggleEditMode(false);
                MessageBox.Show("Data Edit successfully", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RestForm();
            DatGridChange();

            dataGridView1.CurrentCell = null;

            clearError();
        }
        private void EditRowValues(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                // Update cell values in the row
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i == 0)
                    {
                        row.Cells[i].Value = distanceFrom_dropdown.Text;
                    }
                    if (i == 1)
                    {
                        row.Cells[i].Value = distanceTo_dropdown.Text;
                    }
                    if (i == 2)
                    {
                        row.Cells[i].Value = distance_tb.Text;
                    }
                    if (i == 3)
                    {
                        row.Cells[i].Value = grOf_tb.Text;
                    }
                    if (i == 4)
                    {
                        row.Cells[i].Value = Bearing_tb.Text;
                    }
                }
            }
        }

        private string ValidateData()
        {
            if (distanceTo_dropdown.SelectedIndex == -1)
            {

                return "Please enter valid data";
            }
            if (distanceTo_dropdown.SelectedIndex == -1)
            {

                return "Please enter valid data";
            }
            if (distanceFrom_dropdown.SelectedIndex == -1)
            {

                return "Please enter valid data";
            }
            if (SetErrorProviderTextBox(distance_tb) == "ERROR")
            {

                return "Please enter valid data";
            }
            if (SetErrorProviderTextBox(grOf_tb, false) == "ERROR")
            {

                return "Please enter valid data";
            }
            if (SetErrorProviderTextBox(Bearing_tb) == "ERROR")
            {

                return "Please enter valid data";
            }
            if (distanceTo_dropdown.Text == distanceFrom_dropdown.Text)
            {
                return "Distance from and distance to cannot be same";
            }
            if (!IsEditMode && !IsDataUnique())
            {
                return "Data for this distance from and distance to is already present";
            }
            return "NOERROR";
        }
        private bool IsDataUnique()
        {
            // Iterate through DataGridView rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the cell value in the appropriate column matches the new data

                if (row.Cells["DistanceFrom"].Value != null && row.Cells["DistanceTo"].Value != null && row.Cells["DistanceFrom"].Value.ToString() == distanceFrom_dropdown.Text && row.Cells["DistanceTo"].Value.ToString() == distanceTo_dropdown.Text)
                {
                    // Data already exists, return false indicating it's not unique
                    return false;
                }
            }
            // Data is unique, return true
            return true;
        }
        private void clearError()
        {
            errorProvider.SetError(distanceFrom_dropdown, "");
            errorProvider.SetError(distanceTo_dropdown, "");
            errorProvider.SetError(distance_tb, "");
            errorProvider.SetError(grOf_tb, "");
            errorProvider.SetError(Bearing_tb, "");
        }
        private string SetErrorProviderTextBox(TextBox textBox, bool checkdouble = true)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                // Display error if input is empty
                errorProvider.SetError(textBox, "Input Required.");
                return "ERROR";
            }
            else if (checkdouble && !double.TryParse(textBox.Text, out _))
            {
                errorProvider.SetError(textBox, "Enter Valid data");
                return "ERROR";
            }
            else
            {
                // Clear error if input is valid
                errorProvider.SetError(textBox, "");
                return "NOERROR";
            }
        }

        private string SetErrorProviderComboBox(ComboBox dropdown)
        {
            if (dropdown.SelectedIndex == -1) // No item selected
            {
                errorProvider.SetError(dropdown, "Please select a value from the dropdown.");
                return "ERROR";
            }
            else
            {
                errorProvider.SetError(dropdown, ""); // Clear error message
                return "NOERROR";                                     // Proceed with your application logic
            }
        }

        private void distance_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProviderTextBox(textBox);
        }

        private void grOf_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProviderTextBox(textBox, false);
        }

        private void Bearing_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProviderTextBox(textBox);
        }

        private void distanceFrom_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox textBox = (ComboBox)sender;
            //if (SetErrorProviderComboBox(textBox) == "NOERROR")
            //{
            //    grOf_tb.Text = distanceFrom_dropdown.Text;
            //}
        }

        private void distanceTo_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox textBox = (ComboBox)sender;
            SetErrorProviderComboBox(textBox);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

            if (IsEditMode)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel edit mode.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RestForm();
                    ToggleEditMode(false);
                }
            }
            else
            {
                RestForm();
            }

        }
        private void RestForm()
        {
            distanceFrom_dropdown.SelectedIndex = -1;
            distanceTo_dropdown.SelectedIndex = -1;
            distance_tb.Text = "";
            grOf_tb.Text = "";
            Bearing_tb.Text = "";
        }

        public void Reset_btn_Click()
        {
            RestForm();
            ToggleEditMode(false);
            dataGridView1.Rows.Clear();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve data from DataGridView
            DataTable table = new DataTable();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "editColumn" && column.Name != "DeleteColumn")
                {
                    table.Columns.Add(column.HeaderText);
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dataRow = table.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.Name != "editColumn" && cell.OwningColumn.Name != "DeleteColumn")
                    {
                        dataRow[cell.OwningColumn.Index] = cell.Value;
                    }
                }
                table.Rows.Add(dataRow);
            }


            // Create a PDF document
            Document doc = new Document();

            //File Path
            string defaultFilePath = @"Document\MineLayout\temp.pdf";
            string assemblyDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string relativeFilePath = System.IO.Path.Combine(assemblyDirectory, defaultFilePath);

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(relativeFilePath, FileMode.Create));
            doc.Open();

            // Add heading at the top of the page
            iTextSharp.text.Font headingFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            Paragraph heading = new Paragraph("Your Heading", headingFont);
            heading.Alignment = Element.ALIGN_CENTER;
            heading.SpacingAfter = 10f; // Adjust spacing after heading
            doc.Add(heading);

            // Populate the PDF document with table content
            PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
            pdfTable.DefaultCell.Padding = 5;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            // Set table header style
            PdfPCell headerCell = new PdfPCell();
            headerCell.BackgroundColor = new BaseColor(230, 230, 230); // Light gray
            headerCell.Padding = 5;
            headerCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            headerCell.HorizontalAlignment = Element.ALIGN_CENTER;

            // Set table body style
            PdfPCell bodyCell = new PdfPCell();
            bodyCell.Padding = 5;
            bodyCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            bodyCell.HorizontalAlignment = Element.ALIGN_CENTER;

            foreach (DataColumn column in table.Columns)
            {
                headerCell.Phrase = new Phrase(column.ColumnName);
                pdfTable.AddCell(headerCell);
            }

            foreach (DataRow row in table.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    bodyCell.Phrase = new Phrase(item.ToString());
                    pdfTable.AddCell(bodyCell);
                }
            }

            doc.Add(pdfTable);
            doc.Close();



            using (PdfiumViewer.PdfDocument pdfDocument = PdfiumViewer.PdfDocument.Load(relativeFilePath))
            {
                using (PrintDocument printDocument = pdfDocument.CreatePrintDocument())
                {
                    printDocument.PrinterSettings.PrintToFile = true;
                    printDocument.PrinterSettings.PrintFileName = relativeFilePath;
                    printDocument.Print();
                }
            }
        }

        private void Download_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve data from DataGridView
            DataTable table = new DataTable();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "editColumn" && column.Name != "DeleteColumn")
                {
                    table.Columns.Add(column.HeaderText);
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dataRow = table.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.Name != "editColumn" && cell.OwningColumn.Name != "DeleteColumn")
                    {
                        dataRow[cell.OwningColumn.Index] = cell.Value;
                    }
                }
                table.Rows.Add(dataRow);
            }

            // Step 2: Prompt the user to choose the download location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.ShowDialog();

            // Step 3: If the user selected a location, proceed with PDF creation
            if (saveFileDialog.FileName != "")
            {
                // Create a PDF document
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                doc.Open();

                // Add heading at the top of the page
                iTextSharp.text.Font headingFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                Paragraph heading = new Paragraph("Your Heading", headingFont);
                heading.Alignment = Element.ALIGN_CENTER;
                heading.SpacingAfter = 10f;
                doc.Add(heading);

                // Populate the PDF document with table content
                PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                // Set table header style
                PdfPCell headerCell = new PdfPCell();
                headerCell.BackgroundColor = new BaseColor(230, 230, 230); // Light gray
                headerCell.Padding = 5;
                headerCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;

                // Set table body style
                PdfPCell bodyCell = new PdfPCell();
                bodyCell.Padding = 5;
                bodyCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                bodyCell.HorizontalAlignment = Element.ALIGN_CENTER;

                foreach (DataColumn column in table.Columns)
                {
                    headerCell.Phrase = new Phrase(column.ColumnName);
                    pdfTable.AddCell(headerCell);
                }

                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        bodyCell.Phrase = new Phrase(item.ToString());
                        pdfTable.AddCell(bodyCell);
                    }
                }

                doc.Add(pdfTable);
                AddPanelWithDrawing(doc);
                doc.Close();

                MessageBox.Show("PDF generated successfully!");

            }
        }
        private void AddPanelWithDrawing(Document doc)
        {
            // Create a Panel control and add your drawing to it
            Panel panel =drawingPanel;

            // Calculate dimensions for A4 size paper (210mm x 297mm)
            float a4WidthInPoints = PageSize.A4.Width; // A4 width in points
            float a4HeightInPoints = PageSize.A4.Height; // A4 height in points

            // Convert A4 dimensions from points to pixels (assuming 1 inch = 72 points)
            float a4WidthInPixels = a4WidthInPoints * 72 / 25.4f; // A4 width in pixels
            float a4HeightInPixels = a4HeightInPoints * 72 / 25.4f; // A4 height in pixels

            // Calculate the maximum width and height for the drawing within the A4 size sheet
            float maxWidth = 500; // 80% of A4 width
            float maxHeight = 1000; // 80% of A4 height



            // Convert Panel to Image
            Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, panel.Width, panel.Height));

            // Resize the image while maintaining aspect ratio
         
            Size newSize = ResizeImage(bitmap.Size, maxWidth, maxHeight);
            Bitmap resizedImage = new Bitmap(bitmap, newSize);

            // Add the resized image to the PDF document
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(resizedImage, System.Drawing.Imaging.ImageFormat.Bmp);
            doc.Add(image);
        }

        private Size ResizeImage(Size imageSize, float maxWidth, float maxHeight)
        {
            float widthRatio = (float)maxWidth / imageSize.Width;
            float heightRatio = (float)maxHeight / imageSize.Height;
            float scaleFactor = Math.Min(widthRatio, heightRatio);

            int newWidth = (int)(imageSize.Width * scaleFactor);
            int newHeight = (int)(imageSize.Height * scaleFactor);

            return new Size(newWidth, newHeight);
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            string filePath = ((PrintDocument)sender).PrinterSettings.PrintFileName;

            using (System.Drawing.Image image = System.Drawing.Image.FromFile(filePath))
            {
                e.Graphics.DrawImage(image, e.PageBounds);
            }
        }


        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int rectangleLength = (int)(sharedDataModel.Frontage);
            int rectangleWidth = (int)(sharedDataModel.Depth);
            int stripline = (int)(sharedDataModel.Assumed_strips - 1);
            int striplinedistance = (int)(sharedDataModel.stripTostrip);
            int xpadding = 100;
            int ypadding = 50;
            //// Draw the rectangle
            //g.DrawRectangle(Pens.Black, xpadding, ypadding, rectangleLength - 1, rectangleWidth - 1);

            //// Define pen for grid lines
            Pen gridPen = new Pen(System.Drawing.Color.Black);
            gridPen.DashStyle = DashStyle.Dot;

            ////Draw first 30m and last 30 meter strip 

            //g.DrawLine(gridPen, xpadding, ypadding+30, xpadding + rectangleLength, ypadding + 30);
            //g.DrawLine(gridPen, xpadding,rectangleWidth+ ypadding - 30, xpadding + rectangleLength, rectangleWidth + ypadding - 30);

            ////// Draw horizontal grid lines
            //for (int i = 1; i < stripline; i ++)
            //{
            //    g.DrawLine(gridPen, xpadding,( ypadding + 30+ (striplinedistance*i)), xpadding + rectangleLength, (ypadding + 30 + (striplinedistance * i)));
            //}

            // Draw a triangle at point (100, 100)
            int landmarkx = 200;
            //int landmarky = rectangleWidth + ypadding + 20;
            int landmarky = 200;

            Point[] trianglePoints = new Point[]
            {
                 new Point(landmarkx, landmarky),
                new Point(landmarkx+20, landmarky+30),
                new Point(landmarkx-20, landmarky+30)
            };
            g.FillPolygon(Brushes.Red, trianglePoints);


            //draw lines and points based on the data entries 
            drawMarks(ref g, landmarkx, landmarky);
            //  drawPoint(ref g, landmarkx, landmarky);
            // Dispose the pen
            gridPen.Dispose();
        }


        private void drawMarks(ref Graphics g, int landmarkx, int landmarky)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Get the distance, degree, and point name from the DataGridView
                if (row.Cells["Distance"].Value != null && row.Cells["Bearing"].Value != null && row.Cells["DistanceTo"].Value != null && row.Cells["DistanceFrom"].Value != null)
                {
                    double distance = Convert.ToDouble(row.Cells["Distance"].Value);
                    double degree = Convert.ToDouble(row.Cells["Bearing"].Value);
                    string distanceFrom = row.Cells["DistanceFrom"].Value.ToString();
                    string distanceTo = row.Cells["DistanceTo"].Value.ToString();

                    int startPointx = 0;
                    int startPointy = 0;
                    Point fromPoint;
                    if (distanceFrom == "Landmark")
                    {
                        startPointx = landmarkx;
                        startPointy = landmarky;
                        fromPoint = new Point(landmarkx, landmarky);
                    }
                    else
                    {
                        //check for initial point coordinate and save 
                        if (pointsDictionary.ContainsKey(distanceFrom))
                        {
                            // Retrieve the point from the dictionary
                            startPointx = pointsDictionary[distanceFrom].X;
                            startPointy = pointsDictionary[distanceFrom].Y;
                            fromPoint = new Point(startPointx, startPointy);
                        }
                        else
                        {
                            MessageBox.Show("Start Point not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    int offsetX = -drawingPanel.AutoScrollPosition.X;
                    int offsetY = -drawingPanel.AutoScrollPosition.Y;


                    // Calculate the position of the new point based on distance and degree
                    int newX = (int)(startPointx + distance * Math.Cos((degree+270)* Math.PI / 180)); // Convert degree to radians
                    int newY = (int)(startPointy + distance * Math.Sin((degree+270) * Math.PI / 180)); // Convert degree to radians

                    // Draw a line from the landmark point to the new point

                    g.FillEllipse(Brushes.Blue, newX+ offsetX - 3, newY+ offsetY - 3, 6, 6);

                    g.DrawLine(Pens.Black, fromPoint, new Point(newX, newY));

                    // Add the new point to the dictionary
                    if (!pointsDictionary.ContainsKey(distanceTo))
                    {
                        Point newPoint = new Point(newX, newY);
                        pointsDictionary.Add(distanceTo, newPoint);
                    }
                }

            }

        }

        private void drawPoint(ref Graphics g, int landmarkx, int landmarky)
        {
            double angleInRadians = Math.PI / 6; // Convert angle to radians (30 degrees = π/6 radians)
            int distance = 200;
            int pointX = landmarkx + (int)(distance * Math.Sin(angleInRadians));
            int pointY = landmarky - (int)(distance * Math.Cos(angleInRadians)); // Negative sign because Y-axis is inverted in screen coordinates

            // Draw the point
            g.FillEllipse(Brushes.Blue, pointX - 3, pointY - 3, 6, 6);
            g.DrawLine(Pens.Black, landmarkx, landmarky, pointX, pointY);
        }

        private void DatGridChange()
        {
            try
            {
                // Redraw the panel
                drawingPanel.Invalidate();
                // Force immediate repaint
                drawingPanel.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong in creatation of drawing. Please make sure all values are proper", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

