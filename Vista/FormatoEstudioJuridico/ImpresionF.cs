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

    public class ImpresionF
    {
        private static ImpresionF instance = null;
        private ImpresionF()
        {

        }
        public iTextSharp.text.pdf.PdfPTable getTable(spFichaPredialesconsultar_Result objFichaJuridica)
        {

            iTextSharp.text.pdf.PdfPTable tblPrueba = new iTextSharp.text.pdf.PdfPTable(1);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font _titulo = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla

            PdfPCell clnombre = new PdfPCell(new Phrase("FIRMAS ", _titulo));
            clnombre.BorderWidth = 0.75f;
            clnombre.BorderWidthBottom = 1;
            

            PdfPCell clcoordinadorjuridico = new PdfPCell(new Phrase("Coordinador Juridico:"+ objFichaJuridica.coordinador_juridico, _standardFont));
            clcoordinadorjuridico.BorderWidth = 0.5f;
            clcoordinadorjuridico.BorderWidthBottom = 0.75f;
            clcoordinadorjuridico.Colspan = 13;

            PdfPCell clfirmajuridico = new PdfPCell(new Phrase("Firma Juridico:", _standardFont));
            clfirmajuridico.BorderWidth = 0.5f;
            clfirmajuridico.BorderWidthBottom = 0.75f;


            PdfPCell clfechafirmajuridico = new PdfPCell(new Phrase("Fecha Firma Juridico:", _standardFont));
            clfechafirmajuridico.BorderWidth = 0.5f;
            clfechafirmajuridico.BorderWidthBottom = 0.75f;


            PdfPCell cltarjetajuridico = new PdfPCell(new Phrase("Tarjeta Juridico :"+ objFichaJuridica.tarjeta_profesional_juridico, _standardFont));
            cltarjetajuridico.BorderWidth = 0.5f;
            cltarjetajuridico.BorderWidthBottom = 0.75f;


            PdfPCell clcoordinadorcampo= new PdfPCell(new Phrase("Coordinador Campo:"+ objFichaJuridica.quien_elaboro_yaprobo, _standardFont));
            clcoordinadorcampo.BorderWidth = 0.5f;
            clcoordinadorcampo.BorderWidthBottom = 0.75f;


            PdfPCell clnombreinterventor = new PdfPCell(new Phrase("Nombre Interventor:"+ objFichaJuridica.nombre_interventor, _standardFont));
            clnombreinterventor.BorderWidth = 0.5f;
            clnombreinterventor.BorderWidthBottom = 0.75f;


            PdfPCell clfirmainterventor = new PdfPCell(new Phrase("Firma Interventor:", _standardFont));
            clfirmainterventor.BorderWidth = 0.5f;
            clfirmainterventor.BorderWidthBottom = 0.75f;


            PdfPCell clfechafirmainterventor = new PdfPCell(new Phrase("Fecha Firma Interventor:", _standardFont));
            clfechafirmainterventor.BorderWidth = 0.5f;
            clfechafirmainterventor.BorderWidthBottom = 0.75f;


            PdfPCell clfirmaEPM = new PdfPCell(new Phrase("Firma EPM:", _standardFont));
            clfirmaEPM.BorderWidth = 0.5f;
            clfirmaEPM.BorderWidthBottom = 0.75f;



            PdfPCell clfechaFirmaEPM = new PdfPCell(new Phrase("Fecha De Firma EPM:", _standardFont));
            clfechaFirmaEPM.BorderWidth = 0.5f;
            clfechaFirmaEPM.BorderWidthBottom = 0.75f;




            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clnombre);
            tblPrueba.AddCell(clcoordinadorjuridico);
            tblPrueba.AddCell(clfirmajuridico);
            tblPrueba.AddCell(clfechafirmajuridico);
            tblPrueba.AddCell(cltarjetajuridico);
            tblPrueba.AddCell(clcoordinadorcampo);
            tblPrueba.AddCell(clnombreinterventor);
            tblPrueba.AddCell(clfirmainterventor);
            tblPrueba.AddCell(clfechafirmainterventor);
            tblPrueba.AddCell(clfirmaEPM);
            tblPrueba.AddCell(clfechaFirmaEPM);


            return tblPrueba;
        }

        public static ImpresionF Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImpresionF();
                return instance;
            }
        }
    }
}
