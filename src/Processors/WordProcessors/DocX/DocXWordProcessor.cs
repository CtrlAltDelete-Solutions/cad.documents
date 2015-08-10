using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Novacode;


namespace CAD.Core
{
    public class DocXWordProcessor : IWordProcessor
    {
        public void ToPdf(string docFile, string pdfFile)
        {
            throw new NotImplementedException();
        }

        public void ToHtml(string docFile, string htmlFile)
        {
            throw new NotImplementedException();
        }

        public void ReplaceSaveAs(IEnumerable<KeyValuePair<string, string>> replace, string docFile, string targetFile, string searchFormat = "*")
        {
            if(File.Exists(docFile))
            {
                File.Copy(docFile, targetFile, true);

                using (DocX doc = DocX.Load(targetFile))
                {
                    string keyValue;

                    string searchPattern = !String.IsNullOrEmpty(searchFormat) ? searchFormat.Replace("*", "{0}") : null;

                    foreach (KeyValuePair<string, string> formValue in replace)
                    {
                        keyValue = String.Format(searchPattern, formValue.Key);
                        
                        doc.ReplaceText(keyValue, formValue.Value);
                    }

                    doc.Save();
                }

            }

        }

    }
}
