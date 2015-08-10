using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.Core;

namespace CAD.Core.Tools
{
    public class DefaultDocTools
    {
        private static Lazy<IWordManager> _wordManager = new Lazy<IWordManager>(() => new WordManager(new DocXWordProcessor(), DefaultDocTools.XmlManager, DefaultDocTools.PdfManager));
        private static Lazy<IPdfManager> _pdfManager = new Lazy<IPdfManager>(() => new PdfManager(new iTextSharperPdfProcessor(), new HtmlAgilityPackParser()));
        private static Lazy<IXmlManager> _xmlManager = new Lazy<IXmlManager>(() => new XmlManager(new OpenXMLPowerToolsXmlProcessor()));

        public static IWordManager WordManager
        {
            get
            {
                return _wordManager.Value;
            }
        }

        public static IPdfManager PdfManager
        {
            get
            {
                return _pdfManager.Value;
            }
        }

        public static IXmlManager XmlManager
        {
            get
            {
                return _xmlManager.Value;
            }
        }
    }
}
