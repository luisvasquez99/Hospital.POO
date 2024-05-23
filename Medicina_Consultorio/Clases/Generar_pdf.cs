using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;

namespace Medicina_Consultorio
{
    public class Generar : Form
    {
        public class generar
        {
        }
        public void CrearPDF(string plantilla, Dictionary<string, string> reemplazos, string outputPath)
        {
            string PaginaHTML_Texto1 = plantilla;

            foreach (var reemplazo in reemplazos)
            {
                PaginaHTML_Texto1 = PaginaHTML_Texto1.Replace(reemplazo.Key, reemplazo.Value);
            }

            using (FileStream stream = new FileStream(outputPath, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase(""));

                // Agregar la imagen si es necesario
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.c0663a45731ebd3ab9df75b9735d2337, System.Drawing.Imaging.ImageFormat.Png);
                img.ScaleToFit(60, 60);
                img.Alignment = iTextSharp.text.Image.UNDERLYING;
                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                pdfDoc.Add(img);

                using (StringReader sr = new StringReader(PaginaHTML_Texto1))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();
            }
        }
    }
}



    


