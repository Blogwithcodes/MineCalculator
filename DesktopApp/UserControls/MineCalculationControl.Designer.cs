using DesktopApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DesktopApp.UserControls
{
    partial class MineCalculationControl
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
            DropDownModel dropDownModel1 = new DropDownModel();
            DropDownModel dropDownModel2 = new DropDownModel();
            DropDownModel dropDownModel3 = new DropDownModel();
            label1 = new Label();
            frontage_tb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            A_Pers_tb = new TextBox();
            A_Tk_tb = new TextBox();
            Frag_tb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            Anti_Tank_Mines_lbl = new Label();
            Anit_Pers_Mines_Lbl = new Label();
            Anit_Mines_16_lbl = new Label();
            No_of_Mine_lbl = new Label();
            Rate_Of_Laying_lbl = new Label();
            MLPs_Required_lbl = new Label();
            Resul_panel = new Panel();
            panel8 = new Panel();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label30 = new Label();
            panel7 = new Panel();
            frag_strips_lbl = new Label();
            A_tk_strips_lbl = new Label();
            strips_A_Per_Lbl = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            panel6 = new Panel();
            M_16_frag_lbl = new Label();
            ND_Mk_1_lbl = new Label();
            Nmm_14_lbl = new Label();
            label6 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            errorProvider = new ErrorProvider(components);
            label22 = new Label();
            panel9 = new Panel();
            Depth_tb = new TextBox();
            label11 = new Label();
            Inf_safe_Line_tb = new TextBox();
            label10 = new Label();
            VSL_tb = new TextBox();
            MaxStrips_lbl = new Label();
            label20 = new Label();
            minStrips_lbl = new Label();
            label13 = new Label();
            stripAlert_lbl = new Label();
            label21 = new Label();
            Assumedstrip_lbl = new TextBox();
            strips_panel = new Panel();
            striptoStrip_lbl = new Label();
            label12 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            toasterTimer = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            arms_dropdown = new ComboBox();
            label33 = new Label();
            panel3.SuspendLayout();
            Resul_panel.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panel9.SuspendLayout();
            strips_panel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 2;
            label1.Text = "Frontage";
            // 
            // frontage_tb
            // 
            frontage_tb.Location = new Point(107, 24);
            frontage_tb.Name = "frontage_tb";
            frontage_tb.Size = new Size(170, 27);
            frontage_tb.TabIndex = 3;
            frontage_tb.TextChanged += frontage_tb_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 4;
            label2.Text = "Density";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 37);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 5;
            label3.Text = "A/PERS";
            // 
            // A_Pers_tb
            // 
            A_Pers_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            A_Pers_tb.Location = new Point(121, 33);
            A_Pers_tb.Name = "A_Pers_tb";
            A_Pers_tb.Size = new Size(147, 30);
            A_Pers_tb.TabIndex = 6;
            A_Pers_tb.TextChanged += A_Pers_tb_TextChanged;
            // 
            // A_Tk_tb
            // 
            A_Tk_tb.Location = new Point(121, 72);
            A_Tk_tb.Name = "A_Tk_tb";
            A_Tk_tb.Size = new Size(147, 27);
            A_Tk_tb.TabIndex = 7;
            A_Tk_tb.TextChanged += A_Tk_tb_TextChanged;
            // 
            // Frag_tb
            // 
            Frag_tb.Location = new Point(121, 108);
            Frag_tb.Name = "Frag_tb";
            Frag_tb.Size = new Size(147, 27);
            Frag_tb.TabIndex = 8;
            Frag_tb.TextChanged += Frag_tb_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 75);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 9;
            label4.Text = "A/TK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 111);
            label5.Name = "label5";
            label5.Size = new Size(53, 19);
            label5.TabIndex = 10;
            label5.Text = "FRAG";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 72);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 12;
            label7.Text = "ND MK 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 41);
            label8.Name = "label8";
            label8.Size = new Size(69, 19);
            label8.TabIndex = 13;
            label8.Text = "NMM 14";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 105);
            label9.Name = "label9";
            label9.Size = new Size(85, 19);
            label9.TabIndex = 14;
            label9.Text = "M-16 Frag";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.DodgerBlue;
            panel3.Controls.Add(label14);
            panel3.Location = new Point(3, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1313, 45);
            panel3.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 8);
            label14.Name = "label14";
            label14.Size = new Size(93, 29);
            label14.TabIndex = 28;
            label14.Text = "Result ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(129, 28);
            label15.TabIndex = 28;
            label15.Text = "No of Mines";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(3, 76);
            label16.Name = "label16";
            label16.Size = new Size(128, 19);
            label16.TabIndex = 29;
            label16.Text = "Anti Tank Mines:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(3, 40);
            label17.Name = "label17";
            label17.Size = new Size(129, 19);
            label17.TabIndex = 30;
            label17.Text = "Anti Pers Mines:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(3, 109);
            label18.Name = "label18";
            label18.Size = new Size(99, 19);
            label18.TabIndex = 31;
            label18.Text = "Mines M-16:";
            // 
            // Anti_Tank_Mines_lbl
            // 
            Anti_Tank_Mines_lbl.AutoSize = true;
            Anti_Tank_Mines_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Anti_Tank_Mines_lbl.Location = new Point(142, 77);
            Anti_Tank_Mines_lbl.Name = "Anti_Tank_Mines_lbl";
            Anti_Tank_Mines_lbl.Size = new Size(103, 19);
            Anti_Tank_Mines_lbl.TabIndex = 32;
            Anti_Tank_Mines_lbl.Text = "PlaceHolder";
            // 
            // Anit_Pers_Mines_Lbl
            // 
            Anit_Pers_Mines_Lbl.AutoSize = true;
            Anit_Pers_Mines_Lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Anit_Pers_Mines_Lbl.Location = new Point(142, 40);
            Anit_Pers_Mines_Lbl.Name = "Anit_Pers_Mines_Lbl";
            Anit_Pers_Mines_Lbl.Size = new Size(103, 19);
            Anit_Pers_Mines_Lbl.TabIndex = 33;
            Anit_Pers_Mines_Lbl.Text = "PlaceHolder";
            // 
            // Anit_Mines_16_lbl
            // 
            Anit_Mines_16_lbl.AutoSize = true;
            Anit_Mines_16_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Anit_Mines_16_lbl.Location = new Point(142, 111);
            Anit_Mines_16_lbl.Name = "Anit_Mines_16_lbl";
            Anit_Mines_16_lbl.Size = new Size(103, 19);
            Anit_Mines_16_lbl.TabIndex = 34;
            Anit_Mines_16_lbl.Text = "PlaceHolder";
            // 
            // No_of_Mine_lbl
            // 
            No_of_Mine_lbl.AutoSize = true;
            No_of_Mine_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            No_of_Mine_lbl.Location = new Point(195, 44);
            No_of_Mine_lbl.Name = "No_of_Mine_lbl";
            No_of_Mine_lbl.Size = new Size(103, 19);
            No_of_Mine_lbl.TabIndex = 39;
            No_of_Mine_lbl.Text = "PlaceHolder";
            // 
            // Rate_Of_Laying_lbl
            // 
            Rate_Of_Laying_lbl.AutoSize = true;
            Rate_Of_Laying_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Rate_Of_Laying_lbl.Location = new Point(195, 72);
            Rate_Of_Laying_lbl.Name = "Rate_Of_Laying_lbl";
            Rate_Of_Laying_lbl.Size = new Size(103, 19);
            Rate_Of_Laying_lbl.TabIndex = 40;
            Rate_Of_Laying_lbl.Text = "PlaceHolder";
            // 
            // MLPs_Required_lbl
            // 
            MLPs_Required_lbl.AutoSize = true;
            MLPs_Required_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            MLPs_Required_lbl.Location = new Point(195, 107);
            MLPs_Required_lbl.Name = "MLPs_Required_lbl";
            MLPs_Required_lbl.Size = new Size(103, 19);
            MLPs_Required_lbl.TabIndex = 41;
            MLPs_Required_lbl.Text = "PlaceHolder";
            // 
            // Resul_panel
            // 
            Resul_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Resul_panel.BackColor = Color.Transparent;
            Resul_panel.Controls.Add(panel8);
            Resul_panel.Controls.Add(panel7);
            Resul_panel.Controls.Add(panel6);
            Resul_panel.Controls.Add(panel4);
            Resul_panel.Controls.Add(panel3);
            Resul_panel.Location = new Point(0, 332);
            Resul_panel.Margin = new Padding(3, 4, 3, 4);
            Resul_panel.Name = "Resul_panel";
            Resul_panel.Size = new Size(1319, 464);
            Resul_panel.TabIndex = 42;
            Resul_panel.Visible = false;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(label23);
            panel8.Controls.Add(label24);
            panel8.Controls.Add(label25);
            panel8.Controls.Add(MLPs_Required_lbl);
            panel8.Controls.Add(label30);
            panel8.Controls.Add(No_of_Mine_lbl);
            panel8.Controls.Add(Rate_Of_Laying_lbl);
            panel8.Location = new Point(475, 257);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(621, 145);
            panel8.TabIndex = 43;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(3, 3);
            label23.Name = "label23";
            label23.Size = new Size(201, 28);
            label23.TabIndex = 28;
            label23.Text = "Time and Resources";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(8, 72);
            label24.Name = "label24";
            label24.Size = new Size(120, 19);
            label24.TabIndex = 29;
            label24.Text = "Rate of Laying:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(8, 43);
            label25.Name = "label25";
            label25.Size = new Size(183, 19);
            label25.TabIndex = 30;
            label25.Text = "Total Numbers of Mines:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(8, 108);
            label30.Name = "label30";
            label30.Size = new Size(176, 19);
            label30.TabIndex = 31;
            label30.Text = "MLPs Nights Required:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(frag_strips_lbl);
            panel7.Controls.Add(A_tk_strips_lbl);
            panel7.Controls.Add(strips_A_Per_Lbl);
            panel7.Controls.Add(label26);
            panel7.Controls.Add(label27);
            panel7.Controls.Add(label28);
            panel7.Controls.Add(label29);
            panel7.Location = new Point(475, 53);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(621, 164);
            panel7.TabIndex = 44;
            // 
            // frag_strips_lbl
            // 
            frag_strips_lbl.AutoSize = true;
            frag_strips_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            frag_strips_lbl.Location = new Point(264, 111);
            frag_strips_lbl.Name = "frag_strips_lbl";
            frag_strips_lbl.Size = new Size(103, 19);
            frag_strips_lbl.TabIndex = 37;
            frag_strips_lbl.Text = "PlaceHolder";
            // 
            // A_tk_strips_lbl
            // 
            A_tk_strips_lbl.AutoSize = true;
            A_tk_strips_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            A_tk_strips_lbl.Location = new Point(264, 77);
            A_tk_strips_lbl.Name = "A_tk_strips_lbl";
            A_tk_strips_lbl.Size = new Size(103, 19);
            A_tk_strips_lbl.TabIndex = 36;
            A_tk_strips_lbl.Text = "PlaceHolder";
            // 
            // strips_A_Per_Lbl
            // 
            strips_A_Per_Lbl.AutoSize = true;
            strips_A_Per_Lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            strips_A_Per_Lbl.Location = new Point(264, 44);
            strips_A_Per_Lbl.Name = "strips_A_Per_Lbl";
            strips_A_Per_Lbl.Size = new Size(103, 19);
            strips_A_Per_Lbl.TabIndex = 35;
            strips_A_Per_Lbl.Text = "PlaceHolder";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(3, 4);
            label26.Name = "label26";
            label26.Size = new Size(126, 28);
            label26.TabIndex = 11;
            label26.Text = "No of Strips";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(3, 76);
            label27.Name = "label27";
            label27.Size = new Size(237, 19);
            label27.TabIndex = 12;
            label27.Text = "No of strips due to A-Tk density";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(3, 45);
            label28.Name = "label28";
            label28.Size = new Size(253, 19);
            label28.TabIndex = 13;
            label28.Text = "No of strips due to A-PER density";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(3, 112);
            label29.Name = "label29";
            label29.Size = new Size(229, 19);
            label29.TabIndex = 14;
            label29.Text = "No of strips due to Frag mines";
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(M_16_frag_lbl);
            panel6.Controls.Add(ND_Mk_1_lbl);
            panel6.Controls.Add(Nmm_14_lbl);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(16, 257);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(452, 145);
            panel6.TabIndex = 43;
            // 
            // M_16_frag_lbl
            // 
            M_16_frag_lbl.AutoSize = true;
            M_16_frag_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            M_16_frag_lbl.Location = new Point(96, 104);
            M_16_frag_lbl.Name = "M_16_frag_lbl";
            M_16_frag_lbl.Size = new Size(103, 19);
            M_16_frag_lbl.TabIndex = 37;
            M_16_frag_lbl.Text = "PlaceHolder";
            // 
            // ND_Mk_1_lbl
            // 
            ND_Mk_1_lbl.AutoSize = true;
            ND_Mk_1_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ND_Mk_1_lbl.Location = new Point(96, 71);
            ND_Mk_1_lbl.Name = "ND_Mk_1_lbl";
            ND_Mk_1_lbl.Size = new Size(103, 19);
            ND_Mk_1_lbl.TabIndex = 36;
            ND_Mk_1_lbl.Text = "PlaceHolder";
            // 
            // Nmm_14_lbl
            // 
            Nmm_14_lbl.AutoSize = true;
            Nmm_14_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Nmm_14_lbl.Location = new Point(96, 41);
            Nmm_14_lbl.Name = "Nmm_14_lbl";
            Nmm_14_lbl.Size = new Size(103, 19);
            Nmm_14_lbl.TabIndex = 35;
            Nmm_14_lbl.Text = "PlaceHolder";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 11;
            label6.Text = "Mine Available ";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(Anti_Tank_Mines_lbl);
            panel4.Controls.Add(Anit_Pers_Mines_Lbl);
            panel4.Controls.Add(Anit_Mines_16_lbl);
            panel4.Location = new Point(10, 53);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(458, 159);
            panel4.TabIndex = 42;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(A_Pers_tb);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(A_Tk_tb);
            panel5.Controls.Add(Frag_tb);
            panel5.Location = new Point(18, 77);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(282, 148);
            panel5.TabIndex = 43;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(3, 37);
            label22.Name = "label22";
            label22.Size = new Size(40, 19);
            label22.TabIndex = 5;
            label22.Text = "VSL";
            label22.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel9
            // 
            panel9.Controls.Add(Depth_tb);
            panel9.Controls.Add(label11);
            panel9.Controls.Add(Inf_safe_Line_tb);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(VSL_tb);
            panel9.Controls.Add(label22);
            panel9.Location = new Point(386, 77);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(282, 148);
            panel9.TabIndex = 44;
            // 
            // Depth_tb
            // 
            Depth_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Depth_tb.Location = new Point(122, 101);
            Depth_tb.Name = "Depth_tb";
            Depth_tb.Size = new Size(147, 30);
            Depth_tb.TabIndex = 15;
            Depth_tb.TextChanged += Depth_tb_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 112);
            label11.Name = "label11";
            label11.Size = new Size(52, 19);
            label11.TabIndex = 14;
            label11.Text = "Depth";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // Inf_safe_Line_tb
            // 
            Inf_safe_Line_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Inf_safe_Line_tb.Location = new Point(122, 66);
            Inf_safe_Line_tb.Name = "Inf_safe_Line_tb";
            Inf_safe_Line_tb.Size = new Size(147, 30);
            Inf_safe_Line_tb.TabIndex = 13;
            Inf_safe_Line_tb.TextChanged += Inf_safe_Line_tb_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 72);
            label10.Name = "label10";
            label10.Size = new Size(110, 19);
            label10.TabIndex = 12;
            label10.Text = "INF Safe Line";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // VSL_tb
            // 
            VSL_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            VSL_tb.Location = new Point(122, 31);
            VSL_tb.Name = "VSL_tb";
            VSL_tb.Size = new Size(147, 30);
            VSL_tb.TabIndex = 11;
            VSL_tb.TextChanged += VSL_tb_TextChanged;
            // 
            // MaxStrips_lbl
            // 
            MaxStrips_lbl.AutoSize = true;
            MaxStrips_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            MaxStrips_lbl.Location = new Point(135, 48);
            MaxStrips_lbl.Name = "MaxStrips_lbl";
            MaxStrips_lbl.Size = new Size(103, 19);
            MaxStrips_lbl.TabIndex = 40;
            MaxStrips_lbl.Text = "PlaceHolder";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(8, 48);
            label20.Name = "label20";
            label20.Size = new Size(124, 19);
            label20.TabIndex = 39;
            label20.Text = "Maximum Strips";
            label20.TextAlign = ContentAlignment.TopCenter;
            // 
            // minStrips_lbl
            // 
            minStrips_lbl.AutoSize = true;
            minStrips_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            minStrips_lbl.Location = new Point(135, 29);
            minStrips_lbl.Name = "minStrips_lbl";
            minStrips_lbl.Size = new Size(103, 19);
            minStrips_lbl.TabIndex = 38;
            minStrips_lbl.Text = "PlaceHolder";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(8, 29);
            label13.Name = "label13";
            label13.Size = new Size(121, 19);
            label13.TabIndex = 6;
            label13.Text = "Minimum Strips";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // stripAlert_lbl
            // 
            stripAlert_lbl.AutoSize = true;
            stripAlert_lbl.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            stripAlert_lbl.ForeColor = Color.Red;
            stripAlert_lbl.Location = new Point(6, 0);
            stripAlert_lbl.Name = "stripAlert_lbl";
            stripAlert_lbl.Size = new Size(1078, 19);
            stripAlert_lbl.TabIndex = 41;
            stripAlert_lbl.Text = "Please change the strip as per your requirement. Please make sure the strip to strip distance can't be less than 25 and greater than 150 ";
            stripAlert_lbl.TextAlign = ContentAlignment.TopCenter;
            stripAlert_lbl.Visible = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(402, 63);
            label21.Name = "label21";
            label21.Size = new Size(51, 19);
            label21.TabIndex = 46;
            label21.Text = "Strips";
            label21.TextAlign = ContentAlignment.TopCenter;
            // 
            // Assumedstrip_lbl
            // 
            Assumedstrip_lbl.Location = new Point(483, 59);
            Assumedstrip_lbl.Name = "Assumedstrip_lbl";
            Assumedstrip_lbl.Size = new Size(170, 27);
            Assumedstrip_lbl.TabIndex = 47;
            // 
            // strips_panel
            // 
            strips_panel.BorderStyle = BorderStyle.FixedSingle;
            strips_panel.Controls.Add(striptoStrip_lbl);
            strips_panel.Controls.Add(label12);
            strips_panel.Controls.Add(button1);
            strips_panel.Controls.Add(MaxStrips_lbl);
            strips_panel.Controls.Add(stripAlert_lbl);
            strips_panel.Controls.Add(label20);
            strips_panel.Controls.Add(Assumedstrip_lbl);
            strips_panel.Controls.Add(minStrips_lbl);
            strips_panel.Controls.Add(label21);
            strips_panel.Controls.Add(label13);
            strips_panel.Location = new Point(3, 224);
            strips_panel.Name = "strips_panel";
            strips_panel.Size = new Size(1251, 101);
            strips_panel.TabIndex = 48;
            strips_panel.Visible = false;
            // 
            // striptoStrip_lbl
            // 
            striptoStrip_lbl.AutoSize = true;
            striptoStrip_lbl.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            striptoStrip_lbl.ForeColor = Color.DarkRed;
            striptoStrip_lbl.Location = new Point(182, 71);
            striptoStrip_lbl.Name = "striptoStrip_lbl";
            striptoStrip_lbl.Size = new Size(103, 19);
            striptoStrip_lbl.TabIndex = 50;
            striptoStrip_lbl.Text = "PlaceHolder";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(8, 71);
            label12.Name = "label12";
            label12.Size = new Size(168, 19);
            label12.TabIndex = 49;
            label12.Text = "Strip to strip distance ";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(675, 58);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 48;
            button1.Text = "Re-calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(arms_dropdown);
            panel2.Controls.Add(label33);
            panel2.Location = new Point(703, 77);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 115);
            panel2.TabIndex = 45;
            // 
            // arms_dropdown
            // 
            arms_dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            arms_dropdown.FormattingEnabled = true;
            dropDownModel1.Label = "Infantry";
            dropDownModel1.Value = 500;
            dropDownModel2.Label = "Engineer";
            dropDownModel2.Value = 700;
            dropDownModel3.Label = "PMF";
            dropDownModel3.Value = 350;
            arms_dropdown.Items.AddRange(new object[] { dropDownModel1, dropDownModel2, dropDownModel3 });
            arms_dropdown.Location = new Point(119, 35);
            arms_dropdown.Name = "arms_dropdown";
            arms_dropdown.Size = new Size(151, 28);
            arms_dropdown.TabIndex = 12;
            arms_dropdown.SelectionChangeCommitted += ArmsChanged;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label33.Location = new Point(56, 42);
            label33.Name = "label33";
            label33.Size = new Size(47, 19);
            label33.TabIndex = 5;
            label33.Text = "Arms";
            label33.TextAlign = ContentAlignment.TopCenter;
            // 
            // MineCalculationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panel2);
            Controls.Add(strips_panel);
            Controls.Add(Resul_panel);
            Controls.Add(panel9);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(frontage_tb);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MineCalculationControl";
            Size = new Size(1319, 796);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            Resul_panel.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            strips_panel.ResumeLayout(false);
            strips_panel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox frontage_tb;
        private Label label2;
        private Label label3;
        private TextBox A_Pers_tb;
        private TextBox A_Tk_tb;
        private TextBox Frag_tb;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel3;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label Anti_Tank_Mines_lbl;
        private Label Anit_Pers_Mines_Lbl;
        private Label Anit_Mines_16_lbl;
        private Label No_of_Mine_lbl;
        private Label Rate_Of_Laying_lbl;
        private Label MLPs_Required_lbl;
        private Panel Resul_panel;
        private Label MessageBox_lbl;
        private Panel panel4;
        private Panel panel5;
        private Label label6;
        private Panel panel6;
        private Label Nmm_14_lbl;
        private Panel panel7;
        private Label frag_strips_lbl;
        private Label A_tk_strips_lbl;
        private Label strips_A_Per_Lbl;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label M_16_frag_lbl;
        private Label ND_Mk_1_lbl;
        private Panel panel8;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label30;
        private ErrorProvider errorProvider;
        private Panel panel9;
        private TextBox VSL_tb;
        private Label label22;
        private TextBox Depth_tb;
        private Label label11;
        private TextBox Inf_safe_Line_tb;
        private Label label10;
        private Label label20;
        private Label minStrips_lbl;
        private Label label13;
        private Label MaxStrips_lbl;
        private Label label21;
        private Label stripAlert_lbl;
        private TextBox Assumedstrip_lbl;
        private Panel strips_panel;
        private Button button1;
        private Label striptoStrip_lbl;
        private Label label12;
        private Panel panel1;
        private Label label19;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer toasterTimer;
        private Panel panel2;
        private ComboBox arms_dropdown;
        private Label label33;
    }
}
