using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.tool.xml.pipeline.css;

namespace CAD.Core
{
    public class CssResolver : ICSSResolver
    {

        public void AddCss(iTextSharp.tool.xml.css.ICssFile file)
        {
            throw new NotImplementedException();
        }

        public void AddCss(string content, bool isPersistent)
        {
            throw new NotImplementedException();
        }

        public void AddCss(string content, string charSet, bool isPersistent)
        {
            throw new NotImplementedException();
        }

        public void AddCssFile(string href, bool isPersistent)
        {
            throw new NotImplementedException();
        }

        public ICSSResolver Clear()
        {
            throw new NotImplementedException();
        }

        public iTextSharp.tool.xml.net.IFileRetrieve FileRetrieve
        {
            set { throw new NotImplementedException(); }
        }

        public void ResolveStyles(iTextSharp.tool.xml.Tag t)
        {
            throw new NotImplementedException();
        }
    }
}
