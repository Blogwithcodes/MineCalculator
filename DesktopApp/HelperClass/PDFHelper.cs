using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.HelperClass
{
    public static class PDFHelper
    {


        public static Boolean GeneratePdfFromTemplate(string templatePath, string outputPath,ref Dictionary<string, string> placeHolders)
        {
            PdfReader reader = null;
            FileStream fileStream = null;
            PdfStamper stamper = null;

            try
            {
                reader = new PdfReader(templatePath);
                fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
                stamper = new PdfStamper(reader, fileStream);


                // FormField come from the textfield from your PDF so is you need any change alter the text field in pdf and there properties 
                var formFields = stamper.AcroFields;

                // Replace placeholders with actual values
                foreach (var field in formFields.Fields.Keys)
                {
                    foreach (var placeholder in placeHolders)
                    {
                        if (field.Contains(placeholder.Key))
                            formFields.SetField(field, placeholder.Value);
                    }
                }

                stamper.FormFlattening = true;
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                // Ensure all resources are properly closed
                stamper?.Close();
                reader?.Close();
                fileStream?.Close();
            }
        }
    }
    public class PlaceholderReplacer
    {
        private Dictionary<string, string> placeholderDictionary;

        public PlaceholderReplacer()
        {
            // Initialize the placeholder dictionary
            placeholderDictionary = new Dictionary<string, string>();
        }

        // Add a placeholder and its corresponding value to the dictionary
        public void AddPlaceholder(string placeholder, string value)
        {
            placeholderDictionary[placeholder] = value;
        }

        // Replace placeholders in the input string with their corresponding values
        public void ReplacePlaceholders(string input, ref RichTextBox richTextBox)
        {
            string rtfContent = richTextBox.Rtf;
            foreach (var placeholder in placeholderDictionary)
            {
                string pattern = $"@@{placeholder.Key}@@";
                rtfContent = Regex.Replace(rtfContent, pattern, placeholder.Value, RegexOptions.IgnoreCase);
            }
            richTextBox.Rtf = rtfContent;
        }


        
    }
}
