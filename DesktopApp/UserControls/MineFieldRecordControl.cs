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
            if ( 
                String.IsNullOrEmpty(LOC_tb.Text) 
                //||
                //String.IsNullOrEmpty(LayingUnit_tb.Text) ||
                //String.IsNullOrEmpty(AuthorityForLaying_Tb.Text) ||
                //String.IsNullOrEmpty(StartDateTime_Tb.Text) ||
                //String.IsNullOrEmpty(CompletionDateTime_Tb.Text) ||
                //String.IsNullOrEmpty(SubmissionDateTime_tb.Text) ||
                //String.IsNullOrEmpty(SubmittedTo_tb.Text) 
                )
            {
                MessageBox.Show("Please fill All the required Value");
                return;
            }

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Define the relative paths
            string templateRelativePath = @"StaticResource\Templates\MineFieldRecordTemplate.pdf";


            // Combine the base directory with the relative paths to get the absolute paths
            string templatePath = Path.Combine(baseDirectory, templateRelativePath);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = @"output" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputPath = saveFileDialog.FileName;



                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
                    keyValuePairs.Add("{{LOC}}", LOC_tb.Text);
                    keyValuePairs.Add("{{LayingUnit}}", LayingUnit_tb.Text);
                    keyValuePairs.Add("{{AuthorityForLaying}}", AuthorityForLaying_Tb.Text);
                    keyValuePairs.Add("{{StartDateTime}}", StartDateTime_Tb.Text);
                    keyValuePairs.Add("{{CompletionDateTime}}", CompletionDateTime_Tb.Text);
                    keyValuePairs.Add("{{SubmissionDate}}", SubmissionDateTime_tb.Text);
                    keyValuePairs.Add("{{SubmittedTo}}", SubmittedTo_tb.Text);
                    keyValuePairs.Add("{{OfficerInCharge}}", OfficerInChargerLaying_Tb.Text);
                    keyValuePairs.Add("{{NoAndRank}}", NoAndRank_tb.Text);
                    keyValuePairs.Add("{{Name}}", Name_tb.Text);
                    keyValuePairs.Add("{{Sign}}", Sign_tb.Text);
                    keyValuePairs.Add("{{CompassNo}}", CompassNo_tb.Text);
                    keyValuePairs.Add("{{CompassError}}", CompassError_tb.Text);

                    var response = PDFHelper.GeneratePdfFromTemplate(templatePath, outputPath, ref keyValuePairs);
                    if (response)
                    {
                        MessageBox.Show("PDF generated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Something went will generating the File, please connect with you application administrator ");
                    }
                }
            }
        }
    }
}
