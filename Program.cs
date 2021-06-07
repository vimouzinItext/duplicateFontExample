using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.PdfCleanup;
using System;
using System.Collections.Generic;

namespace ConsoleApp32
{
    class Program
    {
        static String pathToFontFile = "SFUIDisplay-Medium.ttf";
        static String pathToOutputFile = "CorrectWayOfReusingFonts.pdf";
        static void Main(string[] args)
        {
            PdfDocument pdf = new PdfDocument(new PdfWriter(pathToOutputFile));
            Document doc = new Document(pdf);
            for (int i = 0; i < 10; i++)
            {
                PdfFont font = PdfFontFactory.CreateFont(pathToFontFile, true);
                Paragraph p = new Paragraph();
                p.SetFont(font);
                p.Add("Fonts will be duplicated since we are creaitng a new instance of PdfFontObject");
                doc.Add(p);
            }
            doc.Close();
        }
    }
}
