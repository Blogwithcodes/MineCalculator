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
    public partial class ParameterMarkingStoreControl : UserControl
    {
        SharedDataModel sharedDataModel = new SharedDataModel();
        public ParameterMarkingStoreControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();
        }

        public void InitCalculate()
        {
            try
            {
                depth_lbl.Text = sharedDataModel.Depth.ToString() + " m";
                paremeter_lbl.Text = CalculateParameter() + " m";
                Barbed_lbl.Text = CalculateBarbed() + " Bundle";
                Mine_Fd_lbl.Text = CalculateMineFd() + " Nos";
                LAIPS_lbl.Text = CalculateLAIPS() + " Nos";
                Wire_22_lbl.Text = CalculateWire22() + " Nos";
                ISL_lbl.Text = CalculateISL() + " m";
                VSL_Lbl.Text = CalculateVSL() + " m";
                SAIPS_lbl.Text = CalculateSAIP() + " Nos";
                Total_Saip_lbl.Text = CalculateTotalSaip() + " Nos";
                Total_SIG_Cable_lbl.Text = CalculateTotalSigCable() + " m";

                //update sharedModel
                sharedDataModel.Perimeter = double.Parse(CalculateParameter());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string CalculateTotalSigCable()
        {

            // Calculate the result using the formula
            if (double.TryParse(CalculateISL(), out double isl) && double.TryParse(CalculateVSL(), out double vsl))
            {
                double _result = isl + vsl;
                return Math.Ceiling(_result).ToString();
            }
            else
            {
                MessageBox.Show("Please be sure to enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }


        }
        private string CalculateTotalSaip()
        {

            // Calculate the result using the formula
            if (double.TryParse(CalculateISL(), out double isl) && double.TryParse(CalculateVSL(), out double vsl))
            {
                double _result = (isl + vsl) / 20;
                return Math.Ceiling(_result).ToString();
            }
            else
            {
                MessageBox.Show("Please be sure to enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }


        }
        private string CalculateSAIP()
        {

            // Calculate the result using the formula
            if (double.TryParse(CalculateISL(), out double isl) && double.TryParse(CalculateVSL(), out double vsl))
            {
                double _result = (isl + vsl) / 20;
                return Math.Ceiling(_result).ToString();
            }
            else
            {
                MessageBox.Show("Please be sure to enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }


        }
        private string CalculateISL()
        {

            // Calculate the result using the formula
            double _result = (sharedDataModel.Depth * sharedDataModel.Inf_Safe_Line) + ((sharedDataModel.Depth * sharedDataModel.Inf_Safe_Line) * 0.1);

            // Display the result
            return Math.Ceiling(_result).ToString();

        }
        private string CalculateVSL()
        {

            // Calculate the result using the formula
            double _result = (sharedDataModel.Depth * 2 * sharedDataModel.VSL) + ((sharedDataModel.Depth * 2 * sharedDataModel.VSL) * 0.1);

            // Display the result
            return Math.Ceiling(_result).ToString();

        }
        private string CalculateWire22()
        {

            // Calculate the result using the formula
            double _result = double.Parse(CalculateMineFd()) * 0.15;

            // Display the result
            return Math.Ceiling(_result).ToString();

        }
        private string CalculateLAIPS()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling(double.Parse(CalculateParameter()) / 12.5) + ((double.Parse(CalculateParameter()) / 12.5) * 0.1);

            // Display the result
            return _result.ToString();

        }
        private string CalculateMineFd()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling((double.Parse(CalculateParameter()) / 50) + ((double.Parse(CalculateParameter()) / 50) * 0.1));

            // Display the result
            return _result.ToString();

        }
        private string CalculateBarbed()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling((double.Parse(CalculateParameter()) / 100) * 2 * 1.1);

            // Display the result
            return _result.ToString();

        }
        private string CalculateParameter()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling(((sharedDataModel.Frontage + sharedDataModel.Depth) * 2));

            // Display the result
            return _result.ToString();

        }
    }
}
