namespace DesktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            reviewButton = new Button();
            menu_toggle_btn = new Button();
            Reset_btn = new Button();
            MineLayingCalculation = new Label();
            Run_btn = new Button();
            sidePanel = new Panel();
            MineFeldReocrdPanel = new Panel();
            button9 = new Button();
            pictureBox10 = new PictureBox();
            MineFieldLayout_panel = new Panel();
            button6 = new Button();
            pictureBox9 = new PictureBox();
            bottomSidePanel = new Panel();
            button8 = new Button();
            ParimeterPanel = new Panel();
            button7 = new Button();
            pictureBox8 = new PictureBox();
            TPTPanel = new Panel();
            button5 = new Button();
            pictureBox6 = new PictureBox();
            NiSignPanel = new Panel();
            button4 = new Button();
            pictureBox5 = new PictureBox();
            NavigationPanel = new Panel();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            SettingPanel = new Panel();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            AccessoriesPanel = new Panel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            MineNavpanel = new Panel();
            MineCalculation_btn = new Button();
            pictureBox1 = new PictureBox();
            sidebar_Timer = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            mainPanel = new Panel();
            pictureBox7 = new PictureBox();
            toastTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            sidePanel.SuspendLayout();
            MineFeldReocrdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            MineFieldLayout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            bottomSidePanel.SuspendLayout();
            ParimeterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            TPTPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            NiSignPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            AccessoriesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            MineNavpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(reviewButton);
            panel1.Controls.Add(menu_toggle_btn);
            panel1.Controls.Add(Reset_btn);
            panel1.Controls.Add(MineLayingCalculation);
            panel1.Controls.Add(Run_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1319, 56);
            panel1.TabIndex = 0;
            // 
            // reviewButton
            // 
            reviewButton.BackColor = Color.LimeGreen;
            reviewButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            reviewButton.ForeColor = SystemColors.ButtonHighlight;
            reviewButton.Location = new Point(863, 5);
            reviewButton.Name = "reviewButton";
            reviewButton.Size = new Size(143, 47);
            reviewButton.TabIndex = 29;
            reviewButton.Text = "Review";
            reviewButton.UseVisualStyleBackColor = false;
            reviewButton.Visible = false;
            reviewButton.Click += reviewButton_Click_1;
            // 
            // menu_toggle_btn
            // 
            menu_toggle_btn.BackgroundImage = (Image)resources.GetObject("menu_toggle_btn.BackgroundImage");
            menu_toggle_btn.BackgroundImageLayout = ImageLayout.Stretch;
            menu_toggle_btn.Location = new Point(7, 8);
            menu_toggle_btn.Margin = new Padding(3, 4, 3, 4);
            menu_toggle_btn.Name = "menu_toggle_btn";
            menu_toggle_btn.Size = new Size(46, 44);
            menu_toggle_btn.TabIndex = 28;
            menu_toggle_btn.UseVisualStyleBackColor = true;
            menu_toggle_btn.Click += menu_toggle_btn_Click;
            // 
            // Reset_btn
            // 
            Reset_btn.BackColor = Color.Gray;
            Reset_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Reset_btn.ForeColor = SystemColors.ButtonHighlight;
            Reset_btn.Location = new Point(1173, 7);
            Reset_btn.Name = "Reset_btn";
            Reset_btn.Size = new Size(143, 47);
            Reset_btn.TabIndex = 27;
            Reset_btn.Text = "Reset";
            Reset_btn.UseVisualStyleBackColor = false;
            Reset_btn.Click += Reset_btn_Click;
            // 
            // MineLayingCalculation
            // 
            MineLayingCalculation.AutoSize = true;
            MineLayingCalculation.BackColor = Color.DarkBlue;
            MineLayingCalculation.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point);
            MineLayingCalculation.ForeColor = Color.WhiteSmoke;
            MineLayingCalculation.Location = new Point(59, 5);
            MineLayingCalculation.Name = "MineLayingCalculation";
            MineLayingCalculation.Padding = new Padding(3);
            MineLayingCalculation.Size = new Size(256, 47);
            MineLayingCalculation.TabIndex = 0;
            MineLayingCalculation.Text = "Digi Recorder";
            MineLayingCalculation.Click += MineLayingCalculation_Click;
            // 
            // Run_btn
            // 
            Run_btn.BackColor = SystemColors.Highlight;
            Run_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Run_btn.ForeColor = SystemColors.ButtonHighlight;
            Run_btn.Location = new Point(1023, 5);
            Run_btn.Name = "Run_btn";
            Run_btn.Size = new Size(143, 47);
            Run_btn.TabIndex = 26;
            Run_btn.Text = "Run";
            Run_btn.UseVisualStyleBackColor = false;
            Run_btn.Click += Run_btn_Click;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.MintCream;
            sidePanel.Controls.Add(MineFeldReocrdPanel);
            sidePanel.Controls.Add(MineFieldLayout_panel);
            sidePanel.Controls.Add(bottomSidePanel);
            sidePanel.Controls.Add(ParimeterPanel);
            sidePanel.Controls.Add(TPTPanel);
            sidePanel.Controls.Add(NiSignPanel);
            sidePanel.Controls.Add(NavigationPanel);
            sidePanel.Controls.Add(SettingPanel);
            sidePanel.Controls.Add(AccessoriesPanel);
            sidePanel.Controls.Add(MineNavpanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 56);
            sidePanel.MaximumSize = new Size(222, 800);
            sidePanel.MinimumSize = new Size(61, 740);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(222, 740);
            sidePanel.TabIndex = 1;
            // 
            // MineFeldReocrdPanel
            // 
            MineFeldReocrdPanel.BackColor = Color.Transparent;
            MineFeldReocrdPanel.Controls.Add(button9);
            MineFeldReocrdPanel.Controls.Add(pictureBox10);
            MineFeldReocrdPanel.Location = new Point(3, 503);
            MineFeldReocrdPanel.Margin = new Padding(3, 4, 3, 4);
            MineFeldReocrdPanel.Name = "MineFeldReocrdPanel";
            MineFeldReocrdPanel.Size = new Size(208, 63);
            MineFeldReocrdPanel.TabIndex = 8;
            MineFeldReocrdPanel.Visible = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(56, 0);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(150, 59);
            button9.TabIndex = 1;
            button9.Text = "Mine Field Record";
            button9.UseVisualStyleBackColor = false;
            button9.Click += MineFieldRecord_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.InitialImage = (Image)resources.GetObject("pictureBox10.InitialImage");
            pictureBox10.Location = new Point(3, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(51, 59);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // MineFieldLayout_panel
            // 
            MineFieldLayout_panel.BackColor = Color.Transparent;
            MineFieldLayout_panel.Controls.Add(button6);
            MineFieldLayout_panel.Controls.Add(pictureBox9);
            MineFieldLayout_panel.Location = new Point(2, 574);
            MineFieldLayout_panel.Margin = new Padding(3, 4, 3, 4);
            MineFieldLayout_panel.Name = "MineFieldLayout_panel";
            MineFieldLayout_panel.Size = new Size(208, 63);
            MineFieldLayout_panel.TabIndex = 7;
            MineFieldLayout_panel.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(56, 0);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(150, 59);
            button6.TabIndex = 1;
            button6.Text = "Mine Field Layout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += MineFieldLayout_click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.InitialImage = (Image)resources.GetObject("pictureBox9.InitialImage");
            pictureBox9.Location = new Point(3, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(51, 59);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // bottomSidePanel
            // 
            bottomSidePanel.BackColor = Color.Transparent;
            bottomSidePanel.BorderStyle = BorderStyle.FixedSingle;
            bottomSidePanel.Controls.Add(button8);
            bottomSidePanel.Dock = DockStyle.Bottom;
            bottomSidePanel.Location = new Point(0, 683);
            bottomSidePanel.Name = "bottomSidePanel";
            bottomSidePanel.Size = new Size(222, 57);
            bottomSidePanel.TabIndex = 8;
            bottomSidePanel.Visible = false;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Location = new Point(7, 8);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(46, 44);
            button8.TabIndex = 30;
            button8.UseVisualStyleBackColor = true;
            button8.Click += TemplateEditor_Click;
            // 
            // ParimeterPanel
            // 
            ParimeterPanel.BackColor = Color.Transparent;
            ParimeterPanel.Controls.Add(button7);
            ParimeterPanel.Controls.Add(pictureBox8);
            ParimeterPanel.Location = new Point(3, 361);
            ParimeterPanel.Margin = new Padding(3, 4, 3, 4);
            ParimeterPanel.Name = "ParimeterPanel";
            ParimeterPanel.Size = new Size(208, 63);
            ParimeterPanel.TabIndex = 6;
            ParimeterPanel.Visible = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(56, 0);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(150, 59);
            button7.TabIndex = 1;
            button7.Text = "Perimeter Marking Store";
            button7.UseVisualStyleBackColor = false;
            button7.Click += ParimeterNab_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.InitialImage = (Image)resources.GetObject("pictureBox8.InitialImage");
            pictureBox8.Location = new Point(3, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(51, 59);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // TPTPanel
            // 
            TPTPanel.BackColor = Color.Transparent;
            TPTPanel.Controls.Add(button5);
            TPTPanel.Controls.Add(pictureBox6);
            TPTPanel.Location = new Point(3, 432);
            TPTPanel.Margin = new Padding(3, 4, 3, 4);
            TPTPanel.Name = "TPTPanel";
            TPTPanel.Size = new Size(208, 63);
            TPTPanel.TabIndex = 6;
            TPTPanel.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(56, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(150, 59);
            button5.TabIndex = 1;
            button5.Text = "TPT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += TPT_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.InitialImage = (Image)resources.GetObject("pictureBox6.InitialImage");
            pictureBox6.Location = new Point(3, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(51, 59);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // NiSignPanel
            // 
            NiSignPanel.BackColor = Color.Transparent;
            NiSignPanel.Controls.Add(button4);
            NiSignPanel.Controls.Add(pictureBox5);
            NiSignPanel.Location = new Point(3, 295);
            NiSignPanel.Margin = new Padding(3, 4, 3, 4);
            NiSignPanel.Name = "NiSignPanel";
            NiSignPanel.Size = new Size(208, 63);
            NiSignPanel.TabIndex = 5;
            NiSignPanel.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(56, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(150, 59);
            button4.TabIndex = 1;
            button4.Text = "NI Sign BDS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += NIStoreNav_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(3, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = Color.Transparent;
            NavigationPanel.Controls.Add(button3);
            NavigationPanel.Controls.Add(pictureBox4);
            NavigationPanel.Location = new Point(3, 230);
            NavigationPanel.Margin = new Padding(3, 4, 3, 4);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(208, 63);
            NavigationPanel.TabIndex = 4;
            NavigationPanel.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(56, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(150, 59);
            button3.TabIndex = 1;
            button3.Text = "Navigation Store";
            button3.UseVisualStyleBackColor = false;
            button3.Click += NavigationNav_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(3, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // SettingPanel
            // 
            SettingPanel.BackColor = Color.Transparent;
            SettingPanel.Controls.Add(button1);
            SettingPanel.Controls.Add(pictureBox3);
            SettingPanel.Location = new Point(3, 159);
            SettingPanel.Margin = new Padding(3, 4, 3, 4);
            SettingPanel.Name = "SettingPanel";
            SettingPanel.Size = new Size(208, 63);
            SettingPanel.TabIndex = 3;
            SettingPanel.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(56, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(150, 59);
            button1.TabIndex = 1;
            button1.Text = "Setting Out Store";
            button1.UseVisualStyleBackColor = false;
            button1.Click += SettingNav_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // AccessoriesPanel
            // 
            AccessoriesPanel.Controls.Add(button2);
            AccessoriesPanel.Controls.Add(pictureBox2);
            AccessoriesPanel.Location = new Point(6, 87);
            AccessoriesPanel.Margin = new Padding(3, 4, 3, 4);
            AccessoriesPanel.Name = "AccessoriesPanel";
            AccessoriesPanel.Size = new Size(205, 64);
            AccessoriesPanel.TabIndex = 3;
            AccessoriesPanel.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(50, -1);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(153, 59);
            button2.TabIndex = 1;
            button2.Text = "Accessories";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AccessoriesNav_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(-5, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // MineNavpanel
            // 
            MineNavpanel.BackColor = Color.Transparent;
            MineNavpanel.Controls.Add(MineCalculation_btn);
            MineNavpanel.Controls.Add(pictureBox1);
            MineNavpanel.Location = new Point(3, 15);
            MineNavpanel.Margin = new Padding(3, 4, 3, 4);
            MineNavpanel.Name = "MineNavpanel";
            MineNavpanel.Size = new Size(208, 63);
            MineNavpanel.TabIndex = 2;
            // 
            // MineCalculation_btn
            // 
            MineCalculation_btn.BackColor = Color.Transparent;
            MineCalculation_btn.BackgroundImageLayout = ImageLayout.Stretch;
            MineCalculation_btn.FlatAppearance.BorderSize = 0;
            MineCalculation_btn.FlatStyle = FlatStyle.Flat;
            MineCalculation_btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            MineCalculation_btn.Location = new Point(55, 0);
            MineCalculation_btn.Margin = new Padding(0);
            MineCalculation_btn.Name = "MineCalculation_btn";
            MineCalculation_btn.Size = new Size(151, 59);
            MineCalculation_btn.TabIndex = 1;
            MineCalculation_btn.Text = "Mine Calculation ";
            MineCalculation_btn.UseVisualStyleBackColor = false;
            MineCalculation_btn.Click += MineNav_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // sidebar_Timer
            // 
            sidebar_Timer.Interval = 10;
            sidebar_Timer.Tick += menuToggleTick;
            // 
            // panel2
            // 
            panel2.Controls.Add(mainPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(222, 56);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 740);
            panel2.TabIndex = 4;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Controls.Add(pictureBox7);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1097, 740);
            mainPanel.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.InitialImage = (Image)resources.GetObject("pictureBox7.InitialImage");
            pictureBox7.Location = new Point(342, 188);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(222, 34);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            pictureBox7.Click += pictureBox7_Click_1;
            // 
            // toastTimer
            // 
            toastTimer.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1319, 796);
            Controls.Add(panel2);
            Controls.Add(sidePanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Digi Recorder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            sidePanel.ResumeLayout(false);
            MineFeldReocrdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            MineFieldLayout_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            bottomSidePanel.ResumeLayout(false);
            ParimeterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            TPTPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            NiSignPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            NavigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            SettingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            AccessoriesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            MineNavpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel sidePanel;
        private Label MineLayingCalculation;
        private Button MineCalculation_btn;
        private PictureBox pictureBox1;
        private Button Run_btn;
        private Button Reset_btn;
        private Label MessageBox_lbl;
        private Panel MineNavpanel;
        private Panel AccessoriesPanel;
        private Button button2;
        private PictureBox pictureBox2;
        private Button menu_toggle_btn;
        private System.Windows.Forms.Timer sidebar_Timer;
        private Panel panel2;
        private Panel mainPanel;
        private Panel SettingPanel;
        private Button button1;
        private PictureBox pictureBox3;
        private Panel TPTPanel;
        private Button button5;
        private PictureBox pictureBox6;
        private Panel NiSignPanel;
        private Button button4;
        private PictureBox pictureBox5;
        private Panel NavigationPanel;
        private Button button3;
        private PictureBox pictureBox4;
        private Panel ParimeterPanel;
        private Button button7;
        private PictureBox pictureBox8;
        private Panel bottomSidePanel;
        private Button button8;
        private PictureBox pictureBox7;
        private System.Windows.Forms.Timer toastTimer;
        private Button reviewButton;
        private Panel MineFieldLayout_panel;
        private Button button6;
        private PictureBox pictureBox9;
        private Panel MineFeldReocrdPanel;
        private Button button9;
        private PictureBox pictureBox10;
    }
}