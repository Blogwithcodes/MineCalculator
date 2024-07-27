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
    public partial class MineFieldRecordControl : UserControl
    {
        SharedDataModel sharedDataModel = new SharedDataModel();
        public MineFieldRecordControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();
        }
        public void InitCalculate()
        {
            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Downlaod_btn_Click(object sender, EventArgs e)
        {
            // Create the PDf 

        }
    }
}
