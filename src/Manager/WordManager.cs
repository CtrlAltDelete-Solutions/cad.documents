using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CAD.Core
{
    public class WordManager : IWordManager
    {
        
        private IWordProcessor _wordProcessor;
        private IXmlManager _xmlManager;
        private IPdfManager _pdfManager;

        public WordManager(IWordProcessor docProc, IXmlManager xmlworker, IPdfManager pdfWorker)
        {
            this._wordProcessor = docProc;
            this._xmlManager = xmlworker;
            this._pdfManager = pdfWorker;
        }


        public void ConvertToPdf(string wordFile, string pdfFile)
        {
            string tempFile = Path.GetTempFileName();
            tempFile = Path.ChangeExtension(tempFile, "html");
            this.ConvertToHtml(wordFile, tempFile);
            this._pdfManager.ConvertFromHtml(tempFile, pdfFile);
            File.Delete(tempFile);
        }

        public void ConvertToHtml(string wordFile, string htmlFile)
        {
            this._xmlManager.ConvertWordToHtml(wordFile, htmlFile);
        }

        public void ReplaceText(IEnumerable<KeyValuePair<string, string>> replace, string wordFile, string searchFormat = null)
        {
            this._wordProcessor.ReplaceSaveAs(replace, wordFile, wordFile, searchFormat);
        }

        public void ReplaceTextToWord(IEnumerable<KeyValuePair<string, string>> replace, string wordFile, string targetFile, string searchFormat = null)
        {
            this._wordProcessor.ReplaceSaveAs(replace, wordFile, targetFile, searchFormat);
        }

        public void ReplaceTextToPdf(IEnumerable<KeyValuePair<string, string>> replace, string wordFile, string pdfFile, string searchFormat = null)
        {
            string tempFile = Path.GetTempFileName();
            tempFile = Path.ChangeExtension(tempFile, Path.GetExtension(wordFile));
            this.ReplaceTextToWord(replace, wordFile, tempFile, searchFormat);
            this.ConvertToPdf(tempFile, pdfFile);
            File.Delete(tempFile);
        }

        public void ReplaceTextToHtml(IEnumerable<KeyValuePair<string, string>> replace, string wordFile, string htmlFile, string searchFormat = null)
        {
            string tempFile = Path.GetTempFileName();
            this.ReplaceTextToWord(replace, wordFile, tempFile, searchFormat);
            this.ConvertToHtml(tempFile, htmlFile);
            File.Delete(tempFile);
        }
    }
}
