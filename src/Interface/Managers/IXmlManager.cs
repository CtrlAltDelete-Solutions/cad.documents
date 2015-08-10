using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Core
{
    public interface IXmlManager
    {
        void ConvertWordToHtml(string wordFile, string htmlFile);
        void ConvertToEmbeddedImages(string htmlFile, string targetHtmlFile);
    }
}
