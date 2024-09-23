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
    public class ImpresionC
    {

        private static ImpresionC instance = null;

        private ImpresionC()
        {

        }
        public iTextSharp.text.pdf.PdfPTable getTable(List<spFichaPredialeHistoriaPropietariosconsultar_Result> lsthistoria,spFichaPredialesconsultar_Result objFichaJuridica)
        {
            iTextSharp.text.pdf.PdfPTable tblPrueba = new iTextSharp.text.pdf.PdfPTable(35);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font _titulo = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clnombre = new PdfPCell(new Phrase("ANALISIS DE FOLIO DE MATRICULA INMOBILIARIA  ", _titulo));
            clnombre.BorderWidth = 0.75f;
            clnombre.BorderWidthBottom = 1;
            clnombre.Colspan = 35;

            PdfPCell clfechaaperturafolio = new PdfPCell(new Phrase("Fecha Apertura Folio:" + objFichaJuridica.fecha_apertura_folio, _standardFont));
            clfechaaperturafolio.BorderWidth = 0.5f;
            clfechaaperturafolio.BorderWidthBottom = 1;
            clfechaaperturafolio.Colspan = 18;

            PdfPCell clfechaprimeraanotacion = new PdfPCell(new Phrase("Fecha Primera Anotacion:" + objFichaJuridica.fecha_primera_anotacion, _standardFont));
            clfechaprimeraanotacion.BorderWidth = 0.5f;
            clfechaprimeraanotacion.BorderWidthBottom = 1;
            clfechaprimeraanotacion.Colspan = 17;

            PdfPCell clcausa = new PdfPCell(new Phrase("Causa Acto", _standardFont));
            clcausa.BorderWidth = 0.75f;
            clcausa.BorderWidthBottom = 1;
            clcausa.Colspan = 5;

            PdfPCell clpropietario = new PdfPCell(new Phrase("Propietario", _standardFont));
            clpropietario.BorderWidth = 0.75f;
            clpropietario.BorderWidthBottom = 1;
            clpropietario.Colspan = 15;

            PdfPCell cltitulo = new PdfPCell(new Phrase("Titulo", _standardFont));
            cltitulo.BorderWidth = 0.75f;
            cltitulo.BorderWidthBottom = 1;
            cltitulo.Colspan = 5;
            PdfPCell clarea = new PdfPCell(new Phrase("Area" + ""+ "M2" , _standardFont));
            clarea.BorderWidth = 0.75f;
            clarea.BorderWidthBottom = 1;
            clarea.Colspan = 5;

            PdfPCell clanotacion = new PdfPCell(new Phrase("anotación", _standardFont));
            clanotacion.BorderWidth = 0.75f;
            clanotacion.BorderWidthBottom = 1;
            clanotacion.Colspan = 5;





            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clnombre);
            tblPrueba.AddCell(clfechaaperturafolio);
            tblPrueba.AddCell(clfechaprimeraanotacion);
            tblPrueba.AddCell(clcausa);
            tblPrueba.AddCell(clpropietario);
            tblPrueba.AddCell(cltitulo);
            tblPrueba.AddCell(clarea);
            tblPrueba.AddCell(clanotacion);
            //le agregamos datos a las columnas
            foreach (spFichaPredialeHistoriaPropietariosconsultar_Result objhistoria in lsthistoria)

            {

                PdfPCell clcausaac = new PdfPCell(new Phrase(objhistoria.causa_acto, _standardFont));
                clcausaac.BorderWidth = 0.5f;
                clcausaac.BorderWidthBottom = 0.75f;
                clcausaac.Colspan = 5;

                PdfPCell clprop = new PdfPCell(new Phrase(objhistoria.propietario, _standardFont));
                clprop.BorderWidth = 0.5f;
                clprop.BorderWidthBottom = 0.75f;
                clprop.Colspan = 15;

                PdfPCell cltit = new PdfPCell(new Phrase(objhistoria.titulo, _standardFont));
                cltit.BorderWidth = 0.5f;
                cltit.BorderWidthBottom = 0.75f;
                cltit.Colspan = 5;

                PdfPCell clar = new PdfPCell(new Phrase(objhistoria.area + " " + "M2", _standardFont));
                clar.BorderWidth = 0.5f;
                clar.BorderWidthBottom = 0.75f;
                clar.Colspan = 5;

                PdfPCell clanot = new PdfPCell(new Phrase(objhistoria.anotacion, _standardFont));
                clanot.BorderWidth = 0.5f;
                clanot.BorderWidthBottom = 0.75f;
                clanot.Colspan = 5;


                tblPrueba.AddCell(clcausaac);
                tblPrueba.AddCell(clprop);
                tblPrueba.AddCell(cltit);
                tblPrueba.AddCell(clar);
                tblPrueba.AddCell(clanot);
            }
            



            // Añadimos las celdas a la tabla
            /*
           tblPrueba.AddCell(clcausa);
            tblPrueba.AddCell(clpropietario);
            tblPrueba.AddCell(cltitulo);
            tblPrueba.AddCell(clfecharegistro);
            tblPrueba.AddCell(clfechaescritura);
            tblPrueba.AddCell(clarea);
            tblPrueba.AddCell(clvendedor);
            tblPrueba.AddCell(clanotacion);*/






            return tblPrueba;

        }
        public static ImpresionC Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImpresionC();

                return instance;
            }
        }
    }
}
