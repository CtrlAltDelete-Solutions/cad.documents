using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Core
{
    public interface IWordProcessor
    {
        void ToPdf(string docFile, string pdfFile);
        void ToHtml(string docFile, string htmlFile);
        void ReplaceSaveAs(IEnumerable<KeyValuePair<string, string>> replace, string docFile, string targetFile, string searchFormat = null);
    }
}
