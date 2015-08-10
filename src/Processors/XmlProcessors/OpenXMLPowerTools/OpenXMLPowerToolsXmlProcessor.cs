using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenXmlPowerTools;
using System.IO;

namespace CAD.Core
{
    public class OpenXMLPowerToolsXmlProcessor : IXmlProcessor
    {

        public OpenXMLPowerToolsXmlProcessor()
        {

        }


        public void WordToHtml(string wordFile, string htmlFile)
        {
            string tempPath = Path.GetTempPath();
            string tempFile = Path.Combine(tempPath, Path.GetFileNameWithoutExtension(htmlFile) + Path.GetExtension(wordFile));

            File.Copy(wordFile, tempFile);
            string targetFolder = Path.GetDirectoryName(htmlFile);

            HtmlConverterHelper.ConvertToHtml(tempFile, targetFolder);

            File.Delete(tempFile);
        }

        
    }
}
