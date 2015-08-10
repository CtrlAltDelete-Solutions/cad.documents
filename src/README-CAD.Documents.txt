Namespace: CAD.Core.Tools
----------------------------------------------------
Usage:

var textToReplace = new Dictionary<string,string>();

//replaces any text from doc file enclosed with {}.. example: {Firstname}
//default format {*}
//this is optional
var textToReplaceFormat = "{{*}}"; 

var docFile = "C:\test.doc";
var pdfFile = "C:\test.pdf";
var htmlFile = "C:\test.html";

//convert to pdf
DocTools.WordManager.ConvertToPdf(docFile,pdfFile);

//replace text then save as doc
DocTools.WordManager.ReplaceTextToWord(textToReplace, docFile, pdfFile);

//replace text and convert to pdf with replace format
DocTools.WordManager.ReplaceTextToPdf(textToReplace, docFile, pdfFile, textToReplaceFormat);

//replace text then convert to html
DocTools.WordManager.ReplaceTextToHtml(textToReplace, docFile, pdfFile, textToReplaceFormat);

//convert html to pdf
DocTools.PdfManager.ConvertFromHtml(htmlFile,pdfFile);

//convert doc to html
DocTools.XmlManager.ConvertWordToHtml(docFile,htmlFile);

----------------------------------------------------------------
NuGet Dependencies:

Json.Net
DocX
HtmlAgilityPack
iTextSharp
iTextSharp XML Worker
OpenXml Power Tools