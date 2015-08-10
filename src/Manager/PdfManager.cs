using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Core
{
    public class PdfManager : IPdfManager
    {
        private readonly IPdfProcessor _pdfProcessor;
        private readonly IXmlParser _xmlParser;

        public PdfManager(IPdfProcessor pdfProcessor, IXmlParser xmlParser)
        {
            this._pdfProcessor = pdfProcessor;
            this._xmlParser = xmlParser;
        }

        public void ConvertFromHtml(string htmlFile, string pdfFile)
        {
            //auto retrieve image path
            string imageRootPath = this._xmlParser.GetImageDirectory(htmlFile);
            this._pdfProcessor.HtmlToPdf(htmlFile, pdfFile, imageRootPath);
        }


    }
}
