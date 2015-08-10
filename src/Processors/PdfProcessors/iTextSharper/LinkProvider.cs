using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.tool.xml.pipeline.html;

namespace CAD.Core
{
    public class LinkProvider : ILinkProvider
    {
        private readonly string _relativePath;
        public LinkProvider(string relativePath)
        {
            this._relativePath = relativePath;
        }
        public string GetLinkRoot()
        {
            return this._relativePath;
        }
    }
}
