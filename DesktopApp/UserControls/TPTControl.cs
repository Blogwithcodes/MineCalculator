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
    public partial class TPTControl : UserControl
    {
        SharedDataModel sharedDataModel = new SharedDataModel();
        public TPTControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();
        }

        public void InitCalculate()
        {
            try
            {
                AntiPers_Lbl.Text = CalculateAntiPers();
                Anti_tk_lbl.Text = CalculateAntiTK();
                Fragment_lbl.Text = CalculateFrag();
                TotalMines_Lbl.Text = $"{CalculateTotalMine()} * ALS";
                sharedDataModel.TotalMineLorry = double.Parse(CalculateTotalMine());
                perimeter.Text = sharedDataModel.Perimeter.ToString();
                lorryLD_lbl.Text = CalculateLorryLd();
                totalVEH_lbl.Text = CalculateTotalVeh();
                TpCarriage.Text = "1*Jeep + 2 * ALS";
                Total_lbl.Text = $" {CalculateTotal()} * HMV + 1 * Jeep";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string CalculateTotal()
        {

            // Calculate the result using the formula
            double _result = double.Parse(totalVEH_lbl.Text) + 1 + 1 + 2;
            return _result.ToString();
        }
        private string CalculateTotalVeh()
        {

            // Calculate the result using the formula
            double _result = sharedDataModel.TotalMineLorry + double.Parse(lorryLD_lbl.Text) + 1;
            return _result.ToString();
        }
        private string CalculateLorryLd()
        {

            // Calculate the result using the formula
            double _result = (Convert.ToInt64(sharedDataModel.Perimeter) / 3000) + 1;
            return _result.ToString();
        }
        private string CalculateTotalMine()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling(double.Parse(AntiPers_Lbl.Text) + double.Parse(Anti_tk_lbl.Text) + double.Parse(Fragment_lbl.Text));
            return _result.ToString();
        }
        private string CalculateFrag()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling(sharedDataModel.M_16_frag / 700);

            return _result.ToString();
        }
        private string CalculateAntiPers()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling(sharedDataModel.Anit_Pers_Mines /8000);

            return _result.ToString();
        }
        private string CalculateAntiTK()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling(sharedDataModel.Anti_Tank_Mines / 225);

            return _result.ToString();
        }

        private void TotalMines_Lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
