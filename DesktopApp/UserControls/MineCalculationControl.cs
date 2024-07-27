using DesktopApp.HelperClass;
using DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.UserControls
{
    public partial class MineCalculationControl : UserControl
    {
        SharedDataModel sharedDataModel;
        public event EventHandler MineCalculatedClick;
        private System.Windows.Forms.Timer toastTimer;
        private Form toastForm;
        public MineCalculationControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();

            //For testing purpose 
            frontage_tb.Text = "1000";
            A_Pers_tb.Text = "1";
            A_Tk_tb.Text = "1";
            Frag_tb.Text = "1";
            VSL_tb.Text = "1";
            Inf_safe_Line_tb.Text = "1";
            Depth_tb.Text = "300";
            arms_dropdown.SelectedIndex = 1;
            Terrain_Dropdown.SelectedIndex = 1;

            // InitializeToastTimer();
        }
        private void CallLoader()
        {
            Form1 mainForm = this.FindForm() as Form1;

            // Check if the main form instance is not null
            if (mainForm != null)
            {
                // Call the public method on the main form
                mainForm.loaderStarter();
            }
        }
        //private void InitializeToastTimer()
        //{
        //    toastTimer = new System.Windows.Forms.Timer();
        //    toastTimer.Interval = 3000; // 3 seconds
        //    toastTimer.Tick += ToastTimer_Tick;
        //}

        //private void ShowToastMessage(string message)
        //{
        //    toastForm = new Form();
        //    toastForm.FormBorderStyle = FormBorderStyle.None;
        //    toastForm.StartPosition = FormStartPosition.Manual;
        //    toastForm.BackColor = System.Drawing.Color.DodgerBlue;// Semi-transparent background color
        //    Label label = new Label();
        //    label.Text = message;
        //    label.ForeColor = System.Drawing.Color.White;
        //    label.Width = 250;
        //    label.Height = 60;
        //    label.Padding = new Padding(10);
        //    toastForm.Width = 250;    
        //    toastForm.Height = 60;    
        //    toastForm.Controls.Add(label);
        //    toastForm.Show();
        //    toastForm.Location = new System.Drawing.Point(
        //        this.Right - toastForm.Width,
        //        this.Bottom - toastForm.Height);
        //    toastTimer.Start();
        //}
        //private void ToastTimer_Tick(object sender, EventArgs e)
        //{
        //    toastTimer.Stop();
        //    CloseToastForms();
        //}

        //private void CloseToastForms()
        //{
        //    if (toastForm != null)
        //    {
        //        toastForm.Close();
        //        toastForm.Dispose();
        //        toastForm = null;
        //    }
        //}

        protected virtual void OnMineCalculatedClick(EventArgs e)
        {
            MineCalculatedClick?.Invoke(this, e);
        }

        public void Run_btn_Click()
        {
            if (ArmsDropdownCheck() == "ERROR")
            {
                Resul_panel.Visible = false;
                MessageBox.Show("Please select arms value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnMineCalculatedClick(EventArgs.Empty);
                return;
            }
            try
            {
                Resul_panel.Visible = true;

                //Number of mines formula
                Anit_Pers_Mines_Lbl.Text = CalculateNoOfMine(A_Pers_tb.Text, frontage_tb.Text);
                Anti_Tank_Mines_lbl.Text = CalculateNoOfMine(A_Tk_tb.Text, frontage_tb.Text);
                Anit_Mines_16_lbl.Text = CalculateNoOfMine(Frag_tb.Text, frontage_tb.Text);
                DropDownModel armSelectedItem = (DropDownModel)arms_dropdown.SelectedItem;
                DropDownModel terrainSelectedItem = (DropDownModel)Terrain_Dropdown.SelectedItem;
                sharedDataModel.RateOfLaying = Helper.GetRateOfLaying((Arms)armSelectedItem.Value,(Terrain) terrainSelectedItem.Value);
                //Time and Resources 
                No_of_Mine_lbl.Text = CalculateTotalMines();
                Rate_Of_Laying_lbl.Text = sharedDataModel.RateOfLaying.ToString() + " MINES/24 HR CYCLE BY " + ((sharedDataModel.RateOfLaying == 700) ? "EMLP" : "MLP");
                MLPs_Required_lbl.Text = CalculateMLP() + " Nos";

                // Avaiable Mines 
                Nmm_14_lbl.Text = Anit_Pers_Mines_Lbl.Text;
                ND_Mk_1_lbl.Text = Anti_Tank_Mines_lbl.Text;
                M_16_frag_lbl.Text = Anit_Mines_16_lbl.Text;

                //No of strips 
                strips_A_Per_Lbl.Text = CalculateStrips("A_PER");
                A_tk_strips_lbl.Text = CalculateStrips("A_TK");
                frag_strips_lbl.Text = CalculateStrips("FRAG");

                UpdateSharedDataModel();
                //Calculate Min and Max strip

                minStrips_lbl.Text = sharedDataModel.Min_strips.ToString();
                MaxStrips_lbl.Text = sharedDataModel.Max_strips.ToString();
                Assumedstrip_lbl.Text = CalculateAssumedStrip().ToString();
                striptoStrip_lbl.Text = Math.Round(CalculateStripToStrpDistance(), 2).ToString();
                strips_panel.Visible = sharedDataModel.IsMineCalculated;
                //Review Button visible 
                OnMineCalculatedClick(EventArgs.Empty);

                CallLoader();

            }
            catch (Exception ex)
            {
                Resul_panel.Visible = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnMineCalculatedClick(EventArgs.Empty);


            }
        }
        private void UpdateSharedDataModel()
        {
            try
            {
                sharedDataModel.Anit_Pers_Mines = double.Parse(Anit_Pers_Mines_Lbl.Text);
                sharedDataModel.Anti_Tank_Mines = double.Parse(Anti_Tank_Mines_lbl.Text);
                sharedDataModel.Anit_Mines_16 = double.Parse(Anit_Mines_16_lbl.Text);
                sharedDataModel.No_of_Mine = double.Parse(No_of_Mine_lbl.Text);
                sharedDataModel.MLPs_Required = double.Parse(CalculateMLP());
                sharedDataModel.Nmm_14 = double.Parse(Nmm_14_lbl.Text);
                sharedDataModel.ND_Mk_1 = double.Parse(ND_Mk_1_lbl.Text);
                sharedDataModel.Rate_Of_Laying = sharedDataModel.RateOfLaying;

                sharedDataModel.M_16_frag = double.Parse(M_16_frag_lbl.Text);
                sharedDataModel.strips_A_Per = double.Parse(strips_A_Per_Lbl.Text);
                sharedDataModel.A_tk_strips = double.Parse(A_tk_strips_lbl.Text);
                sharedDataModel.frag_strips = double.Parse(frag_strips_lbl.Text);

                CalculateMaxMinStrip();
                sharedDataModel.Assumed_strips = CalculateAssumedStrip();
                sharedDataModel.VSL = double.Parse(VSL_tb.Text);
                sharedDataModel.Inf_Safe_Line = double.Parse(Inf_safe_Line_tb.Text);
                sharedDataModel.Depth = double.Parse(Depth_tb.Text);
                sharedDataModel.IsMineCalculated = true;
                sharedDataModel.stripTostrip = CalculateStripToStrpDistance();
                sharedDataModel.Perimeter = (sharedDataModel.Frontage + sharedDataModel.Depth) * 2;
                if (double.TryParse(frontage_tb.Text, out double frontage))
                {
                    sharedDataModel.Frontage = frontage;
                }
                else
                {
                    sharedDataModel.Frontage = 0;
                }
            }
            catch (Exception ex)
            {
                Resul_panel.Visible = false;
                MessageBox.Show("Please be sure to enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        private string CalculateStrips(string calType)
        {
            if (calType == "A_PER")
            {
                if (double.TryParse(A_Pers_tb.Text, out double A_Pers))
                {
                    // Calculate the result using the formula
                    double _result = Math.Round((A_Pers / 1), 2);

                    // Display the result
                    return _result.ToString();
                }
                else
                {
                    throw new Exception("Please enter valid data for A/Pers.");
                }
            }
            if (calType == "A_TK")
            {
                if (double.TryParse(A_Tk_tb.Text, out double A_tk))
                {
                    // Calculate the result using the formula
                    double _result = Math.Round((A_tk / (1.0 / 3.0)), 2);

                    // Display the result
                    return _result.ToString();
                }
                else
                {

                    throw new Exception("Please enter valid data for A/TK.");
                }
            }
            if (calType == "FRAG")
            {
                if (double.TryParse(Frag_tb.Text, out double Frag))
                {
                    // Calculate the result using the formula
                    double _result = Math.Round((Frag / (1.0 / 12.0)), 2);

                    // Display the result
                    return _result.ToString();
                }
                else
                {

                    throw new Exception("Please enter valid data for Frag.");
                }
            }
            return "Error";
        }



        private void CalculateMaxMinStrip()
        {
            double sum_A_Per_A_tk = sharedDataModel.A_tk_strips + sharedDataModel.strips_A_Per;
            if (sum_A_Per_A_tk > sharedDataModel.frag_strips)
            {
                sharedDataModel.Min_strips = sharedDataModel.frag_strips;
                sharedDataModel.Max_strips = sum_A_Per_A_tk;
            }
            else
            {
                sharedDataModel.Min_strips = sum_A_Per_A_tk;
                sharedDataModel.Max_strips = sharedDataModel.frag_strips;
            }
        }

        private double CalculateStripToStrpDistance()
        {
            double result = Math.Ceiling(sharedDataModel.Depth - 60) / (sharedDataModel.Assumed_strips - 1);
            if (result < 25.0 || result > 150)
            {
                stripAlert_lbl.Visible = true;
            }
            else
            {
                stripAlert_lbl.Visible = false;
            }
            return result;
        }
        private double CalculateAssumedStrip()
        {
            double result;
            if (double.TryParse(Assumedstrip_lbl.Text, out double Assumedstrip))
            {
                result = Assumedstrip;
                // Display the result

            }
            else
            {

                result = sharedDataModel.Min_strips;
            }

            return result;
        }
        private string CalculateMLP()
        {
            if (double.TryParse(No_of_Mine_lbl.Text, out double noOfMines))
            {
                // Calculate the result using the formula
                double _result = Math.Ceiling(noOfMines / sharedDataModel.RateOfLaying);

                // Display the result
                return _result.ToString();
            }
            else
            {

                throw new Exception("Please enter valid data for Rate of Laying.");
            }

        }
        private string CalculateTotalMines()
        {
            if (double.TryParse(Anit_Pers_Mines_Lbl.Text, out double Anti_Pers) &&
                double.TryParse(Anti_Tank_Mines_lbl.Text, out double Anti_Tank) &&
                double.TryParse(Anit_Mines_16_lbl.Text, out double Anti_Mines))
            {
                // Calculate the result using the formula
                double _result = Anti_Pers + Anti_Tank + Anti_Mines;

                // Display the result
                return _result.ToString();
            }
            else
            {
                throw new Exception("Error while calculation total mines");
            }

        }
        private string CalculateNoOfMine(string _density, string _frontage)
        {
            if (double.TryParse(_density, out double density) &&
                double.TryParse(_frontage, out double frontage))
            {
                // Calculate the result using the formula
                double _result = (density * frontage) + (0.1 * density * frontage);

                // Display the result
                return _result.ToString();
            }
            else
            {

                throw new Exception("Please enter valid data for Mines density and frontage.");
            }

        }



        public void Reset_btn_Click()
        {

            Resul_panel.Visible = false;
            frontage_tb.Text = "";
            A_Pers_tb.Text = "";
            A_Tk_tb.Text = "";
            Frag_tb.Text = "";
            stripAlert_lbl.Visible = false;
            strips_panel.Visible = false;
            VSL_tb.Text = "";
            Inf_safe_Line_tb.Text = "";
            Depth_tb.Text = "";
            arms_dropdown.SelectedIndex = -1;
            Terrain_Dropdown.SelectedIndex = -1;
            sharedDataModel.Reset();
            OnMineCalculatedClick(EventArgs.Empty);


        }

        private void SetErrorProvider(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                // Display error if input is empty
                errorProvider.SetError(textBox, "Input Required.");
            }
            else if (!double.TryParse(textBox.Text, out _))
            {
                errorProvider.SetError(textBox, "Enter Valid data");
            }
            else
            {
                // Clear error if input is valid
                errorProvider.SetError(textBox, "");
            }
        }
        private void frontage_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void A_Pers_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void A_Tk_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void Frag_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void Rate_of_Laying_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run_btn_Click();
        }

        private void VSL_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void Inf_safe_Line_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void Depth_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void ArmsChanged(object sender, EventArgs e)
        {
            ArmsDropdownCheck();
        }
        private string ArmsDropdownCheck()
        {
            if (arms_dropdown.SelectedIndex == -1) // No item selected
            {
                errorProvider.SetError(arms_dropdown, "Please select a value from the dropdown.");
                return "ERROR";
            }
            else
            {
                errorProvider.SetError(arms_dropdown, ""); // Clear error message
                return "NOERROR";                                     // Proceed with your application logic
            }
        }

        private void arms_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            TerrainDropdownCheck();
        }
        private string TerrainDropdownCheck()
        {
            if (Terrain_Dropdown.SelectedIndex == -1) 
            {
                errorProvider.SetError(Terrain_Dropdown, "Please select a value from the dropdown.");
                return "ERROR";
            }
            else
            {
                errorProvider.SetError(Terrain_Dropdown, ""); 
                return "NOERROR";                                    
            }
        }
    }
}
