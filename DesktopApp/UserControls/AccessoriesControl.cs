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
    public partial class AccessoriesControl : UserControl
    {
        SharedDataModel sharedDataModel = new SharedDataModel();
        public AccessoriesControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();
        }
        public void CalculateAccessories()
        {
            if (sharedDataModel != null && sharedDataModel.IsMineCalculated)
            {
                WoodenPegFrag_Lbl.Text = (Math.Ceiling(sharedDataModel.M_16_frag * 2)).ToString() + " Nos";
                ALDS_lbl.Text = (Math.Ceiling(sharedDataModel.Anti_Tank_Mines * 0.1)).ToString() + " Nos";
                Switch_lbl.Text = (Math.Ceiling(sharedDataModel.Anti_Tank_Mines * 0.1)).ToString() + " Nos";
                Snouts_lbl.Text = (Math.Ceiling(sharedDataModel.Anti_Tank_Mines * 0.1)).ToString() + " Nos";
                detonator_lbl.Text = (Math.Ceiling(sharedDataModel.Anti_Tank_Mines * 0.1 * 2)).ToString() + " Nos";
                GcSlabs_Lbl.Text = (Math.Ceiling(sharedDataModel.Anti_Tank_Mines * 0.1)).ToString() + " Nos";
                JnCLips_lbl.Text = (Math.Ceiling(sharedDataModel.Anti_Tank_Mines * 0.1)).ToString() + " Nos";
                DetonationCord_lbl.Text = (Math.Ceiling(sharedDataModel.Anti_Tank_Mines * 0.1 * 2)).ToString() + " M";
                SealingCaps_lbl.Text = (Math.Ceiling(sharedDataModel.Anti_Tank_Mines * 0.1 * 2)).ToString() + " Nos";
            }
        }

    }
}
