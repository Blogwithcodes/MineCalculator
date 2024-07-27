using DesktopApp.HelperClass;
using DesktopApp.Model;
using DesktopApp.UserControls;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {

        bool SideBarExpend = true;
        NavigationControl navigationControl;
        private Panel activeNav;
        SharedDataModel sharedDataModel = new SharedDataModel();
        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeToastTimer();

            //Subscribe MineCalculateEvent
            MineCalculationControl userControl = GetInstance<MineCalculationControl>();

            if (userControl != null)
            {
                userControl.MineCalculatedClick += OnMineCalculation; ;
            }
        }

        private void InitializeToastTimer()
        {

            // Initialize the timer
            toastTimer = new System.Windows.Forms.Timer();
            toastTimer.Interval = 1000; // 3 seconds
            toastTimer.Tick += ToastTimer_Tick;

        }
        public void loaderStarter()
        {
            pictureBox7.Visible = true;
            // Start the timer
            toastTimer.Start();
        }
        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            // Hide the picture box when the timer ticks
            pictureBox7.Visible = false;
            // Stop the timer to prevent it from ticking again
            toastTimer.Stop();
        }
        private void OnMineCalculation(object? sender, EventArgs e)
        {
            if (sharedDataModel.IsMineCalculated)
            {
                AccessoriesPanel.Visible = true;
                SettingPanel.Visible = true;
                NavigationPanel.Visible = true;
                NiSignPanel.Visible = true;
                ParimeterPanel.Visible = true;
                TPTPanel.Visible = true;
                reviewButton.Visible = true;
                bottomSidePanel.Visible = true;
                MineFieldLayout_panel.Visible = true;
                MineFeldReocrdPanel.Visible= true;

            }
            else
            {
                AccessoriesPanel.Visible = false;
                SettingPanel.Visible = false;
                NavigationPanel.Visible = false;
                NiSignPanel.Visible = false;
                ParimeterPanel.Visible = false;
                TPTPanel.Visible = false;
                reviewButton.Visible = false;
                bottomSidePanel.Visible = false;
                MineFieldLayout_panel.Visible = false;
                MineFeldReocrdPanel.Visible = false;

                navigationControl.Display(0);
                SetActiveButton(MineNavpanel);
            }
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> list = new List<UserControl>() {
                new MineCalculationControl(sharedDataModel),
                new AccessoriesControl(sharedDataModel),
                new SettingOutStoreControl(sharedDataModel),
                new NavigationStoreControl(sharedDataModel),
                new NiSignControl(sharedDataModel),
                new ParameterMarkingStoreControl(sharedDataModel),
                new TPTControl(sharedDataModel),
                new MineFieldRecordControl(sharedDataModel),
                new MineFieldLayoutControl(sharedDataModel),
                new TemplateEditor(sharedDataModel)
            };
            navigationControl = new NavigationControl(list, mainPanel);
            activeNav = MineNavpanel;
            SetActiveButton(activeNav);
        }

        private Panel FindPanel(Control control)
        {
            // Traverse up the control hierarchy to find the parent Panel
            while (control != null)
            {
                if (control is Panel)
                {
                    return (Panel)control;
                }
                control = control.Parent;
            }
            return null;
        }

        private void SetActiveButton(Control control)
        {
            Panel panelFound = FindPanel(control);
            if (panelFound != null)
            {
                // First set Prevous nav inactive 
                SetInactiveButton(activeNav);
                panelFound.BackColor = SystemColors.Control;
                panelFound.BorderStyle = BorderStyle.FixedSingle;
                activeNav = panelFound;
            }
        }

        private void SetInactiveButton(Panel panel)
        {
            panel.BackColor = Color.Transparent;
            panel.BorderStyle = BorderStyle.None;
        }
        private void menuToggleTick(object sender, EventArgs e)
        {
            if (SideBarExpend)
            {
                sidePanel.Width -= 10;
                if (sidePanel.MinimumSize.Width == sidePanel.Width)
                {
                    SideBarExpend = false;
                    sidebar_Timer.Stop();
                }
            }
            else
            {
                sidePanel.Width += 10;
                if (sidePanel.MaximumSize.Width == sidePanel.Width)
                {
                    SideBarExpend = true;
                    sidebar_Timer.Stop();
                }
            }
        }

        private void menu_toggle_btn_Click(object sender, EventArgs e)
        {
            sidebar_Timer.Start();
        }
        private void MineNav_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);
        }

        private void AccessoriesNav_Click(object sender, EventArgs e)
        {
            AccessoriesControl userControl = GetInstance<AccessoriesControl>();

            if (userControl != null)
            {
                userControl.CalculateAccessories();
            }
            navigationControl.Display(1);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);

        }

        private void Run_btn_Click(object sender, EventArgs e)
        {
            MineCalculationControl userControl = GetInstance<MineCalculationControl>();
            if (userControl != null)
            {
                userControl.Run_btn_Click();
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset data? You may lost your calculated value.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MineCalculationControl userControl = GetInstance<MineCalculationControl>();
                if (userControl != null)
                {
                    userControl.Reset_btn_Click();
                }
                MineFieldLayoutControl mineLayout = GetInstance<MineFieldLayoutControl>();
                if (userControl != null)
                {
                    mineLayout.Reset_btn_Click();
                }
            }
        }

        private void MineLayingCalculation_Click(object sender, EventArgs e)
        {

        }

        private void SettingNav_Click(object sender, EventArgs e)
        {
            SettingOutStoreControl userControl = GetInstance<SettingOutStoreControl>();

            if (userControl != null)
            {
                userControl.InitCalculate();
            }
            navigationControl.Display(2);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);
        }

        private void NavigationNav_Click(object sender, EventArgs e)
        {
            NavigationStoreControl userControl = GetInstance<NavigationStoreControl>();

            if (userControl != null)
            {
                userControl.InitCalculate();
            }
            navigationControl.Display(3);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);
        }



        private void NIStoreNav_Click(object sender, EventArgs e)
        {
            NiSignControl userControl = GetInstance<NiSignControl>();

            if (userControl != null)
            {
                userControl.InitCalculate();
            }
            navigationControl.Display(4);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);
        }
        private void ParimeterNab_Click(object sender, EventArgs e)
        {
            ParameterMarkingStoreControl userControl = GetInstance<ParameterMarkingStoreControl>();

            if (userControl != null)
            {
                userControl.InitCalculate();
            }
            navigationControl.Display(5);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);
        }
        private void TPT_Click(object sender, EventArgs e)
        {
            TPTControl userControl = GetInstance<TPTControl>();

            if (userControl != null)
            {
                userControl.InitCalculate();
            }
            navigationControl.Display(6);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            navigationControl.Display(8);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);
        }
        private void MineFieldLayout_click(object sender, EventArgs e)
        {

            MineFieldLayoutControl userControl = GetInstance<MineFieldLayoutControl>();

            if (userControl != null)
            {
                userControl.InitCalculate();
            }
            navigationControl.Display(8);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);
        }
        private void TemplateEditor_Click(object sender, EventArgs e)
        {
            TemplateEditor userControl = GetInstance<TemplateEditor>();

            if (userControl != null)
            {
                userControl.InitCalculate();
            }
            navigationControl.Display(8);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MineNav_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AccessoriesNav_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SettingNav_Click(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            NavigationNav_Click(sender, e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            NIStoreNav_Click(sender, e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TPT_Click(sender, e);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            button6_Click(sender, e);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ParimeterNab_Click(sender, e);
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void reviewButton_Click_1(object sender, EventArgs e)
        {
            TemplateEditor_Click(sender, e);
        }
        private void MineFieldRecord_Click(object sender, EventArgs e)
        {

            MineFieldRecordControl userControl = GetInstance<MineFieldRecordControl>();

            if (userControl != null)
            {
                userControl.InitCalculate();
            }
            navigationControl.Display(7);
            var clickedControl = (Control)sender;
            SetActiveButton(clickedControl);
        }
        

        private T GetInstance<T>() where T : UserControl
        {
            foreach (Control control in navigationControl.userControlList)
            {
                if (control is T userControl)
                {
                    return userControl;
                }
            }
            return null;
        }
    }
}