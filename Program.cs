using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.PdfCleanup;
using System;
using System.Collections.Generic;

namespace ConsoleApp32
{
    class Program
    {
        static String dir = "C:\\Users\\Vitor.Mouzinho\\Downloads\\ConvertPdf-master\\CURRENT\\src\\main\\java\\Annot34511\\";

        static void Main(string[] args)
        {
            PdfDocument pdfDocument = new PdfDocument(new PdfReader(dir + "sample (1).pdf"), new PdfWriter(dir + "test.pdf"));
            PdfPage page = pdfDocument.GetPage(1);
            Rectangle rectangle = new Rectangle(
                    Math.Min(65, 528),
                    page.GetPageSize().GetHeight() - Math.Max(156, 227),
                    Math.Abs(528 - 65),
                    Math.Abs(227 - 156));



            Rectangle rectangle2Page1 = new Rectangle(
                    Math.Min(58, 523),
                    page.GetPageSize().GetHeight() - Math.Max(64, 131),
                    Math.Abs(523 - 58),
                    Math.Abs(131 - 64));





            Rectangle rectangle1ForPage2 = new Rectangle(
                    Math.Min(65, 533),
                    pdfDocument.GetPage(2).GetPageSize().GetHeight() - Math.Max(65, 205),
                    Math.Abs(533 - 65),
                    Math.Abs(205 - 65));

            Rectangle rectangle2ForPage2 = new Rectangle(
                    Math.Min(56, 530),
                    pdfDocument.GetPage(2).GetPageSize().GetHeight() - Math.Max(227, 530),
                    Math.Abs(380 - 56),
                    Math.Abs(380 - 56));


            Rectangle rectangle3 = new Rectangle(
                    Math.Min(40, 302),
                    pdfDocument.GetPage(3).GetPageSize().GetHeight() - Math.Max(88, 154),
                    Math.Abs(302 - 40),
                    Math.Abs(154 - 88));



            IList<PdfCleanUpLocation> locations = new List <PdfCleanUpLocation>();
            locations.Add(new PdfCleanUpLocation(3, rectangle3, ColorConstants.RED));          //  locations.Add(1, new PdfCleanUpLocation(1, rectangle2Page1, ColorConstants.RED));
                                                                                                  // locations.Add(2, new PdfCleanUpLocation(2, rectangle1ForPage2, ColorConstants.RED));
                                                                                                  //locations.add(2, new PdfCleanUpLocation(2, rectangle2ForPage2, ColorConstants.RED));
                                                                                                  // locations.Add(3, new PdfCleanUpLocation(3, rectangle3, ColorConstants.RED));




            PdfCleanUpTool cleaner = new PdfCleanUpTool(pdfDocument, locations);
            cleaner.CleanUp();

            pdfDocument.Close();
        }
    }
}
