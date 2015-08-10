using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;

namespace CAD.Core
{
    public class HtmlAgilityPackParser : IXmlParser
    {
        public string GetImageDirectory(string htmlFile)
        {
            string imageDirectory = "/";

            if(File.Exists(htmlFile))
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.Load(htmlFile);

                if((htmlDoc.ParseErrors == null || htmlDoc.ParseErrors.Count() == 0) && htmlDoc.DocumentNode != null)
                {
                    string imageSrc = htmlDoc.DocumentNode.SelectSingleNode("//img").Attributes["src"].Value;
                    imageDirectory = Path.GetDirectoryName(imageSrc);
                }
            }

            return imageDirectory;
        }
    }
}
