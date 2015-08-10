# cad.documents

NuGet Package: CAD.Documents<br />
PM> Install-Package CAD.Documents<br />
https://www.nuget.org/packages/CAD.Documents/<br />
----------------------------------------------------------------<br />
NuGet Dependencies:<br />
<br />
Json.Net, DocX, HtmlAgilityPack, iTextSharp, iTextSharp XML Worker, OpenXml Power Tools<br />
---------------------------------------------------------<br />
<br />
Namespace: CAD.Core.Tools<br />
----------------------------------------------------<br />
Usage:<br />
<br />
var textToReplace = new Dictionary<string,string>();<br />
<br />
//replaces any text from doc file enclosed with {}.. example: {Firstname}<br />
//default format {\*}<br />
//this is optional<br />
var textToReplaceFormat = "{{\*}}"; <br />
var docFile = "C:\test.doc";<br />
var pdfFile = "C:\test.pdf";<br />
var htmlFile = "C:\test.html";<br />
<br />
//convert to pdf<br />
DocTools.WordManager.ConvertToPdf(docFile,pdfFile);<br />
<br />
//replace text then save as doc<br />
DocTools.WordManager.ReplaceTextToWord(textToReplace, docFile, pdfFile);<br />
<br />
//replace text and convert to pdf with replace format<br />
DocTools.WordManager.ReplaceTextToPdf(textToReplace, docFile, pdfFile, textToReplaceFormat);<br />
<br />
//replace text then convert to html<br />
DocTools.WordManager.ReplaceTextToHtml(textToReplace, docFile, pdfFile, textToReplaceFormat);<br />
<br />
//convert html to pdf<br />
DocTools.PdfManager.ConvertFromHtml(htmlFile,pdfFile);<br />
<br />
//convert doc to html<br />
DocTools.XmlManager.ConvertWordToHtml(docFile,htmlFile);<br />
