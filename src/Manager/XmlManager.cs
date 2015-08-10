using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Core
{
    public class XmlManager : IXmlManager
    {
        private readonly IXmlProcessor _xmlProcessor;

        public XmlManager(IXmlProcessor xmlProcessor)
        {
            this._xmlProcessor = xmlProcessor;
        }

        public void ConvertWordToHtml(string wordFile, string htmlFile)
        {
            this._xmlProcessor.WordToHtml(wordFile, htmlFile);
        }

        public void ConvertToEmbeddedImages(string htmlFile, string targetHtmlFile)
        {
            throw new NotImplementedException();
        }
    }
}
