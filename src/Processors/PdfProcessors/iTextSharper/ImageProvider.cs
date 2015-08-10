using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.tool.xml.pipeline.html;

namespace CAD.Core
{
    public class ImageProvider : IImageProvider
    {
        private readonly string _imgPath;

        public ImageProvider(string imgPath)
        {
            this._imgPath = imgPath;
        }
        
        public string GetImageRootPath()
        {
            return this._imgPath;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public iTextSharp.text.Image Retrieve(string src)
        {
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(src);
            return img;
        }

        public void Store(string src, iTextSharp.text.Image img)
        {
            throw new NotImplementedException();
        }
    }
}
