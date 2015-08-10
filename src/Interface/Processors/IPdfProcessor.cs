using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Core
{
    public interface IPdfProcessor
    {
        void HtmlToPdf(string htmlFile, string pdfFile);
        void HtmlToPdf(string htmlFile, string pdfFile, string htmlImageDirectory);
    }
}

