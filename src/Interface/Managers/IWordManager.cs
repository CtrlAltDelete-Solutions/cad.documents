using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Core
{
    public interface IWordManager
    {
        void ConvertToPdf(string wordFile, string pdfFile);
        void ConvertToHtml(string wordFile, string htmlFile);
        void ReplaceText(IEnumerable<KeyValuePair<string, string>> replace, string docFile, string searchFormat = null);
        void ReplaceTextToWord(IEnumerable<KeyValuePair<string, string>> replace, string wordFile, string targetDocFile, string searchFormat = null);
        void ReplaceTextToPdf(IEnumerable<KeyValuePair<string, string>> replace, string wordFile, string targetPdfFile, string searchFormat = null);
        void ReplaceTextToHtml(IEnumerable<KeyValuePair<string, string>> replace, string wordFile, string targetHtmlFile, string searchFormat = null);
    }
}
