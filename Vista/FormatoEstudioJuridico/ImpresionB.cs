using Datos.EstudioJuridico;
using Datos.Sicafi.Listas;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.FormatoEstudioJuridico
{
    public class ImpresionB
    {

        private static ImpresionB instance = null;

        private ImpresionB()
        {

        }
        public iTextSharp.text.pdf.PdfPTable getTable(Consultar_Predio_Result objPredio, List<Consultar_Propietario_Result> lstConsultarPropietario, List<spFichaPredialPropietariosconsultar_Result> lstanotacion
            )
        {
            iTextSharp.text.pdf.PdfPTable tblPrueba = new iTextSharp.text.pdf.PdfPTable(38);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font _titulo = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla

            PdfPCell clnombre = new PdfPCell(new Phrase("PROPIETARIO ACTUAL DEL PREDIO ", _titulo));
            clnombre.BorderWidth = 0.5f;
            clnombre.BorderWidthBottom = 1;
            clnombre.Colspan = 38;

            PdfPCell clanotacion = new PdfPCell(new Phrase("Anotación", _standardFont));
            clanotacion.BorderWidth = 0.5f;
            clanotacion.BorderWidthBottom = 1;
            clanotacion.Colspan = 7;

            PdfPCell clpropietario = new PdfPCell(new Phrase("Propietario", _standardFont));
            clpropietario.BorderWidth = 0.5f;
            clpropietario.BorderWidthBottom = 1;
            clpropietario.Colspan = 15;

            


            PdfPCell clcedula = new PdfPCell(new Phrase("Cédula", _standardFont));
            clcedula.BorderWidth = 0.5f;
            clcedula.BorderWidthBottom = 1;
            clcedula.Colspan = 8;

            PdfPCell clderecho = new PdfPCell(new Phrase("Derecho", _standardFont));
            clderecho.BorderWidth = 0.5f;
            clderecho.BorderWidthBottom = 0.75f;
            clderecho.Colspan = 8;






            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clnombre);
            tblPrueba.AddCell(clanotacion);
            tblPrueba.AddCell(clpropietario);
            tblPrueba.AddCell(clcedula);
            tblPrueba.AddCell(clderecho);
            
            // le agregamos datos a las columnas
            foreach(Consultar_Propietario_Result objPropietario in lstConsultarPropietario)
            {
                foreach (spFichaPredialPropietariosconsultar_Result objPropietarioant in lstanotacion)
                {
                    PdfPCell clAnot = new PdfPCell(new Phrase(objPropietarioant.anotacion, _standardFont));
                    clAnot.BorderWidth = 0.5f;
                    clAnot.BorderWidthBottom = 0.75f;
                    clAnot.Colspan = 7;
                    

               


                    PdfPCell clNombre = new PdfPCell(new Phrase(objPropietario.strNombreApellido, _standardFont));
                    clNombre.BorderWidth = 0.5f;
                    clNombre.BorderWidthBottom = 0.75f;
                    clNombre.Colspan = 15;               
                    PdfPCell clcedulaprop = new PdfPCell(new Phrase(objPropietario.strDocumento, _standardFont));
                    clcedulaprop.BorderWidth = 0.5f;
                    clcedulaprop.BorderWidthBottom = 0.75f;
                    clcedulaprop.Colspan = 8;
                    PdfPCell clderechopro = new PdfPCell(new Phrase(objPropietario.strDerecho, _standardFont));
                    clderechopro.BorderWidth = 0.5f;
                    clderechopro.BorderWidthBottom = 0.75f;
                    clderechopro.Colspan = 8;


                    tblPrueba.AddCell(clAnot);
                    tblPrueba.AddCell(clNombre);       
                    tblPrueba.AddCell(clcedulaprop);
                    tblPrueba.AddCell(clderechopro);

                }
            }
            


        



            return tblPrueba;

        }
        public static ImpresionB Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImpresionB();

                return instance;
            }
        }
    }
}
