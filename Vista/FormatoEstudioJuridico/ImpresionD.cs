using Datos.EstudioJuridico;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.FormatoEstudioJuridico
{
    public class ImpresionD
    {
        private static ImpresionD instance = null;
        private ImpresionD()
        {

        }
        
       public iTextSharp.text.pdf.PdfPTable getTable(List<spMatriculaDerivadasconsultar_Result> lstmalstmatriculas)
        {
            iTextSharp.text.pdf.PdfPTable tblPrueba = new iTextSharp.text.pdf.PdfPTable(35);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font _titulo = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clnombre = new PdfPCell(new Phrase("MATRICULAS DERIVADAS ", _titulo));
            clnombre.BorderWidth = 1;
            clnombre.BorderWidthBottom = 1;
            clnombre.Colspan = 35;

            PdfPCell clmatricula = new PdfPCell(new Phrase("Matricula", _standardFont));
            clmatricula.BorderWidth = 0.5f;
            clmatricula.BorderWidthBottom = 1;
            clmatricula.Colspan = 5;

            PdfPCell clestado = new PdfPCell(new Phrase("Estado", _standardFont));
            clestado.BorderWidth = 0.5f;
            clestado.BorderWidthBottom = 1;
            clestado.Colspan = 5;

            PdfPCell clpkpredio = new PdfPCell(new Phrase("Pk Predio", _standardFont));
            clpkpredio.BorderWidth = 0.5f;
            clpkpredio.BorderWidthBottom = 1;
            clpkpredio.Colspan = 10;

            PdfPCell clubicar = new PdfPCell(new Phrase("Ubicar", _standardFont));
            clubicar.BorderWidth = 0.5f;
            clubicar.BorderWidthBottom = 0.75f;
            clubicar.Colspan = 15;




            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clnombre);
            tblPrueba.AddCell(clmatricula);
            tblPrueba.AddCell(clestado);
            tblPrueba.AddCell(clpkpredio);
            tblPrueba.AddCell(clubicar);


            foreach(spMatriculaDerivadasconsultar_Result objMatricula in lstmalstmatriculas)
            {
              
                PdfPCell clmatri = new PdfPCell(new Phrase(objMatricula.matricula, _standardFont));
                clmatri.BorderWidth = 0.5f;
                clmatri.BorderWidthBottom = 1;
                clmatri.Colspan = 5;

                PdfPCell clesta = new PdfPCell(new Phrase("Estado", _standardFont));
                clesta.BorderWidth = 0.5f;
                clesta.BorderWidthBottom = 1;
                clesta.Colspan = 5;

                PdfPCell clpk = new PdfPCell(new Phrase(objMatricula.pk_predio, _standardFont));
                clpk.BorderWidth = 0.5f;
                clpk.BorderWidthBottom = 1;
                clpk.Colspan = 10;

                PdfPCell clubi = new PdfPCell(new Phrase(objMatricula.ubicar, _standardFont));
                clubi.BorderWidth = 0.5f;
                clubi.BorderWidthBottom = 0.75f;
                clubi.Colspan = 15;

               
                tblPrueba.AddCell(clmatri);
                tblPrueba.AddCell(clesta);
                tblPrueba.AddCell(clpk);
                tblPrueba.AddCell(clubi);


            }







            return tblPrueba;

        }
        public static ImpresionD Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImpresionD();
                return instance;
            }
        }
    }

 
}
