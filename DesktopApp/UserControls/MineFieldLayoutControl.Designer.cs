namespace DesktopApp.UserControls
{
    partial class MineFieldLayoutControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            drawingContainerPanel = new Panel();
            label6 = new Label();
            drawingPanel = new Panel();
            editPanel = new Panel();
            Test_Btn = new Button();
            button3 = new Button();
            button2 = new Button();
            savebtn = new Button();
            grOf_tb = new TextBox();
            Bearing_tb = new TextBox();
            distance_tb = new TextBox();
            distanceTo_dropdown = new ComboBox();
            distanceFrom_dropdown = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            woodenPeg = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            drawingContainerPanel.SuspendLayout();
            editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 27);
            label1.TabIndex = 3;
            label1.Text = "Mine Field Layout";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1057, 214);
            dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(drawingContainerPanel);
            panel1.Controls.Add(editPanel);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(26, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 831);
            panel1.TabIndex = 5;
            // 
            // drawingContainerPanel
            // 
            drawingContainerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drawingContainerPanel.Controls.Add(label6);
            drawingContainerPanel.Controls.Add(drawingPanel);
            drawingContainerPanel.Location = new Point(17, 383);
            drawingContainerPanel.Name = "drawingContainerPanel";
            drawingContainerPanel.Size = new Size(1069, 445);
            drawingContainerPanel.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 11);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 23);
            label6.TabIndex = 6;
            label6.Text = "Drawing Preview";
            // 
            // drawingPanel
            // 
            drawingPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drawingPanel.AutoScroll = true;
            drawingPanel.AutoSize = true;
            drawingPanel.BackColor = Color.LightSkyBlue;
            drawingPanel.Location = new Point(12, 37);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(728, 405);
            drawingPanel.TabIndex = 0;
            drawingPanel.Paint += DrawingPanel_Paint;
            // 
            // editPanel
            // 
            editPanel.Controls.Add(Test_Btn);
            editPanel.Controls.Add(button3);
            editPanel.Controls.Add(button2);
            editPanel.Controls.Add(savebtn);
            editPanel.Controls.Add(grOf_tb);
            editPanel.Controls.Add(Bearing_tb);
            editPanel.Controls.Add(distance_tb);
            editPanel.Controls.Add(distanceTo_dropdown);
            editPanel.Controls.Add(distanceFrom_dropdown);
            editPanel.Controls.Add(label5);
            editPanel.Controls.Add(label4);
            editPanel.Controls.Add(label3);
            editPanel.Controls.Add(label2);
            editPanel.Controls.Add(woodenPeg);
            editPanel.Location = new Point(17, 3);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(1057, 154);
            editPanel.TabIndex = 5;
            // 
            // Test_Btn
            // 
            Test_Btn.BackColor = Color.SkyBlue;
            Test_Btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Test_Btn.ForeColor = Color.Black;
            Test_Btn.Location = new Point(687, 106);
            Test_Btn.Name = "Test_Btn";
            Test_Btn.Size = new Size(163, 43);
            Test_Btn.TabIndex = 18;
            Test_Btn.Text = "Test";
            Test_Btn.UseVisualStyleBackColor = false;
            Test_Btn.Click += Test_Btn_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(872, 106);
            button3.Name = "button3";
            button3.Size = new Size(163, 43);
            button3.TabIndex = 17;
            button3.Text = "Download";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Download_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(246, 106);
            button2.Name = "button2";
            button2.Size = new Size(163, 43);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Cancel_Click;
            // 
            // savebtn
            // 
            savebtn.BackColor = Color.LimeGreen;
            savebtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            savebtn.ForeColor = Color.WhiteSmoke;
            savebtn.Location = new Point(19, 106);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(210, 43);
            savebtn.TabIndex = 14;
            savebtn.Text = "Add To table";
            savebtn.UseVisualStyleBackColor = false;
            savebtn.Click += Save_Click;
            // 
            // grOf_tb
            // 
            grOf_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grOf_tb.Location = new Point(165, 53);
            grOf_tb.Name = "grOf_tb";
            grOf_tb.Size = new Size(147, 30);
            grOf_tb.TabIndex = 13;
            grOf_tb.TextChanged += grOf_tb_TextChanged;
            // 
            // Bearing_tb
            // 
            Bearing_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Bearing_tb.Location = new Point(507, 53);
            Bearing_tb.Name = "Bearing_tb";
            Bearing_tb.Size = new Size(147, 30);
            Bearing_tb.TabIndex = 12;
            Bearing_tb.TextChanged += Bearing_tb_TextChanged;
            // 
            // distance_tb
            // 
            distance_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distance_tb.Location = new Point(836, 11);
            distance_tb.Name = "distance_tb";
            distance_tb.Size = new Size(147, 30);
            distance_tb.TabIndex = 11;
            distance_tb.TextChanged += distance_tb_TextChanged;
            // 
            // distanceTo_dropdown
            // 
            distanceTo_dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            distanceTo_dropdown.FormattingEnabled = true;
            distanceTo_dropdown.Location = new Point(507, 13);
            distanceTo_dropdown.Name = "distanceTo_dropdown";
            distanceTo_dropdown.Size = new Size(147, 28);
            distanceTo_dropdown.TabIndex = 10;
            distanceTo_dropdown.SelectedIndexChanged += distanceTo_dropdown_SelectedIndexChanged;
            // 
            // distanceFrom_dropdown
            // 
            distanceFrom_dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            distanceFrom_dropdown.FormattingEnabled = true;
            distanceFrom_dropdown.Location = new Point(165, 13);
            distanceFrom_dropdown.Name = "distanceFrom_dropdown";
            distanceFrom_dropdown.Size = new Size(147, 28);
            distanceFrom_dropdown.TabIndex = 9;
            distanceFrom_dropdown.SelectedIndexChanged += distanceFrom_dropdown_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(376, 57);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 22);
            label5.TabIndex = 8;
            label5.Text = "Bearing";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 57);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 22);
            label4.TabIndex = 7;
            label4.Text = "GR of ____";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(733, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 22);
            label3.TabIndex = 6;
            label3.Text = "Distance ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(376, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 5;
            label2.Text = "Distance To";
            // 
            // woodenPeg
            // 
            woodenPeg.AutoSize = true;
            woodenPeg.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            woodenPeg.Location = new Point(19, 15);
            woodenPeg.Margin = new Padding(4, 0, 4, 0);
            woodenPeg.Name = "woodenPeg";
            woodenPeg.Size = new Size(139, 22);
            woodenPeg.TabIndex = 4;
            woodenPeg.Text = "Distance from";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // MineFieldLayoutControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MineFieldLayoutControl";
            Size = new Size(1156, 883);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            drawingContainerPanel.ResumeLayout(false);
            drawingContainerPanel.PerformLayout();
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel editPanel;
        private ComboBox distanceTo_dropdown;
        private ComboBox distanceFrom_dropdown;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label woodenPeg;
        private Button savebtn;
        private TextBox grOf_tb;
        private TextBox Bearing_tb;
        private TextBox distance_tb;
        private ErrorProvider errorProvider;
        private Button button2;
        private Button button3;
        private Panel drawingContainerPanel;
        private Panel drawingPanel;
        private Label label6;
        private Button Test_Btn;
    }
}
