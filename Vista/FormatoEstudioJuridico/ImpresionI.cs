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
    class ImpresionI
    {
        private static ImpresionI instance = null;

        private ImpresionI()
        {

        }
        public iTextSharp.text.pdf.PdfPTable getTable(List<spFichaPredialeHistoriaPropietariosconsultar_Result> lsthistoria)
        {
            iTextSharp.text.pdf.PdfPTable tblPrueba = new iTextSharp.text.pdf.PdfPTable(36);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla

            PdfPCell clanotacion = new PdfPCell(new Phrase("anotación", _standardFont));
            clanotacion.BorderWidth = 0.75f;
            clanotacion.BorderWidthBottom = 1;
            clanotacion.Colspan = 5;


            PdfPCell clfecharegistro = new PdfPCell(new Phrase("Fecha Registro", _standardFont));
            clfecharegistro.BorderWidth = 0.5f;
            clfecharegistro.BorderWidthBottom = 1;
            clfecharegistro.Colspan = 8;

            PdfPCell clfechaescritura = new PdfPCell(new Phrase("Fecha Escritura", _standardFont));
            clfechaescritura.BorderWidth = 0.5f;
            clfechaescritura.BorderWidthBottom = 1;
            clfechaescritura.Colspan = 8;

          

            PdfPCell clvendedor = new PdfPCell(new Phrase("Vendedor", _standardFont));
            clvendedor.BorderWidth = 0.5f;
            clvendedor.BorderWidthBottom = 1;
            clvendedor.Colspan = 15;




            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clanotacion);
            tblPrueba.AddCell(clfecharegistro);
            tblPrueba.AddCell(clfechaescritura);
            tblPrueba.AddCell(clvendedor);

            // le añadimos datos a las columnas
            foreach (spFichaPredialeHistoriaPropietariosconsultar_Result objhistoria in lsthistoria)
            {

                PdfPCell clanot = new PdfPCell(new Phrase(objhistoria.anotacion, _standardFont));
                clanot.BorderWidth = 0.5f;
                clanot.BorderWidthBottom = 0.75f;
                clanot.Colspan = 5;

                PdfPCell clfecharegi = new PdfPCell(new Phrase(Convert.ToString(objhistoria.fecha_registro), _standardFont));
                clfecharegi.BorderWidth = 0.5f;
                clfecharegi.BorderWidthBottom = 0.75f;
                clfecharegi.Colspan = 8;

                PdfPCell clfechaes = new PdfPCell(new Phrase(Convert.ToString(objhistoria.fecha_escritura), _standardFont));
                clfechaes.BorderWidth = 0.5f;
                clfechaes.BorderWidthBottom = 0.75f;
                clfechaes.Colspan = 8;

                PdfPCell clven = new PdfPCell(new Phrase(objhistoria.vendedor_anterior, _standardFont));
                clven.BorderWidth = 0.5f;
                clven.BorderWidthBottom = 0.75f;
                clven.Colspan = 15;


                tblPrueba.AddCell(clanot);
                tblPrueba.AddCell(clfecharegi);
                tblPrueba.AddCell(clfechaes);
                tblPrueba.AddCell(clven);

                
            }


         



            return tblPrueba;

        }
        public static ImpresionI Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImpresionI();

                return instance;
            }
        }
    }
}
