package addFont;

import com.itextpdf.io.font.FontConstants;
import com.itextpdf.kernel.font.PdfFont;
import com.itextpdf.kernel.font.PdfFontFactory;
import com.itextpdf.kernel.pdf.PdfDocument;
import com.itextpdf.kernel.pdf.PdfReader;
import com.itextpdf.kernel.pdf.PdfWriter;
import com.itextpdf.layout.Document;
import com.itextpdf.layout.element.Paragraph;
import com.itextpdf.licensekey.LicenseKey;

import java.io.IOException;

public class Main {
    static String pathToFontFile = "SFUIDisplay-Medium.ttf";
    static String pathToOutputFile ="CorrectWayOfReusingFonts.pdf";
     public static void main(String[] args) throws IOException {
        PdfDocument pdf = new PdfDocument(new PdfWriter(pathToOutputFile));
        Document doc = new Document(pdf);
        for(int i = 0; i < 10;i++){
            PdfFont font = PdfFontFactory.createFont(pathToFontFile,true);
            Paragraph p = new Paragraph();
            p.setFont(font);
            p.add("Fonts will be duplicated since we are creaitng a new instance of PdfFontObject");
            doc.add(p);
        }
        doc.close();
    }
}
