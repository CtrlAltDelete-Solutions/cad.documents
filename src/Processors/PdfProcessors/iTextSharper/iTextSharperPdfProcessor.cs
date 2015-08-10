using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.tool.xml.css;
using iTextSharp.tool.xml.html;
using iTextSharp.tool.xml.parser;
using iTextSharp.tool.xml.pipeline.css;
using iTextSharp.tool.xml.pipeline.end;
using iTextSharp.tool.xml.pipeline.html;

namespace CAD.Core
{
    //using iTextSharper
    //http://codereply.com/answer/7526sn/can-itextsharpxmlworker-render-embedded-images.html
    //http://www.itextpdf.com/sandbox/xmlworker/D09_ParseHtmlImagesLinks
    //http://www.itextpdf.com/sandbox/xmlworker
    public class iTextSharperPdfProcessor : IPdfProcessor
    {
        public void HtmlToPdf(string htmlFile, string pdfFile)
        {
            throw new NotImplementedException();
        }

        public void HtmlToPdf(string htmlFile, string pdfFile, string htmlImageDirectory)
        {
            using (FileStream pdfStream = new FileStream(pdfFile, FileMode.OpenOrCreate))
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, pdfStream);
                doc.Open();

                //TODO: apply external css
                ICSSResolver cssResolver = XMLWorkerHelper.GetInstance().GetDefaultCssResolver(true);

                //HTML
                HtmlPipelineContext htmlContext = new HtmlPipelineContext(null);
                htmlContext.SetTagFactory(Tags.GetHtmlTagProcessorFactory());
                htmlContext.SetImageProvider(new ImageProvider(htmlImageDirectory));
                htmlContext.SetLinkProvider(new LinkProvider("/"));

                //pipelines
                PdfWriterPipeline pdf = new PdfWriterPipeline(doc, writer);
                HtmlPipeline html = new HtmlPipeline(htmlContext, pdf);
                CssResolverPipeline css = new CssResolverPipeline(cssResolver, html);

                XMLWorker worker = new XMLWorker(css, true);
                XMLParser p = new XMLParser(true, worker, Encoding.UTF8);

                using (TextReader reader = File.OpenText(htmlFile))
                {
                    p.Parse(reader);
                }

                doc.Close();
            }
        }
    }
}
