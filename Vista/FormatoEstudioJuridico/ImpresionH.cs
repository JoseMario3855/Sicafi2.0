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
    class ImpresionH
    {
        private static ImpresionH instance = null;

        private ImpresionH()
        {

        }
        public iTextSharp.text.pdf.PdfPTable getTable(Consultar_Predio_Result objPredio, List<Consultar_Propietario_Result> lstConsultarPropietario)
        {
            iTextSharp.text.pdf.PdfPTable tblPrueba = new iTextSharp.text.pdf.PdfPTable(46);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clfechaescritura = new PdfPCell(new Phrase("Fecha Escritura", _standardFont));
            clfechaescritura.BorderWidth = 0.75f;
            clfechaescritura.BorderWidthBottom = 1;
            clfechaescritura.Colspan = 8;

            PdfPCell clfecharegistro = new PdfPCell(new Phrase("Fecha Registro", _standardFont));
            clfecharegistro.BorderWidth = 0.75f;
            clfecharegistro.BorderWidthBottom = 1;
            clfecharegistro.Colspan = 8;


            PdfPCell clcausaacto = new PdfPCell(new Phrase("Causa Acto", _standardFont));
            clcausaacto.BorderWidth = 0.75f;
            clcausaacto.BorderWidthBottom = 1;
            clcausaacto.Colspan = 5;

            PdfPCell clescritura = new PdfPCell(new Phrase("Escritura", _standardFont));
            clescritura.BorderWidth = 0.75f;
            clescritura.BorderWidthBottom = 1;
            clescritura.Colspan = 5;

            PdfPCell cldepartamento = new PdfPCell(new Phrase("Departamento", _standardFont));
            cldepartamento.BorderWidth = 0.75f;
            cldepartamento.BorderWidthBottom = 1;
            cldepartamento.Colspan = 9;

            PdfPCell clmunicipio = new PdfPCell(new Phrase("Municipio", _standardFont));
            clmunicipio.BorderWidth = 0.75f;
            clmunicipio.BorderWidthBottom = 1;
            clmunicipio.Colspan = 5;

            PdfPCell clnotaria = new PdfPCell(new Phrase("Notaria", _standardFont));
            clnotaria.BorderWidth = 0.75f;
            clnotaria.BorderWidthBottom = 1;
            clnotaria.Colspan = 6;

            // Añadimos las celdas a la tabla
            
            tblPrueba.AddCell(clfechaescritura);
            tblPrueba.AddCell(clfecharegistro);
            tblPrueba.AddCell(clcausaacto);
            tblPrueba.AddCell(clescritura);
            tblPrueba.AddCell(cldepartamento);
            tblPrueba.AddCell(clmunicipio);
            tblPrueba.AddCell(clnotaria);
            // le añadimos datos a las columnas
            foreach (Consultar_Propietario_Result objPropietario in lstConsultarPropietario)
            {
                
                PdfPCell clfecha = new PdfPCell(new Phrase(objPropietario.strFecha, _standardFont));
                clfecha.BorderWidth = 0.5f;
                clfecha.BorderWidthBottom = 0.75f;
                clfecha.Colspan = 8;
                PdfPCell clregistro = new PdfPCell(new Phrase(objPropietario.strFechaRegistro, _standardFont));
                clregistro.BorderWidth = 0.5f;
                clregistro.BorderWidthBottom = 0.75f;
                clregistro.Colspan = 8;
              
                PdfPCell clcausaactopro = new PdfPCell(new Phrase(objPropietario.strCausaActo, _standardFont));
                clcausaactopro.BorderWidth = 0.5f;
                clcausaactopro.BorderWidthBottom = 0.75f;
                clcausaactopro.Colspan = 5;
                PdfPCell clescri = new PdfPCell(new Phrase(objPropietario.strEscritura, _standardFont));
                clescri.BorderWidth = 0.5f;
                clescri.BorderWidthBottom = 0.75f;
                clescri.Colspan = 5;
                PdfPCell cldepa = new PdfPCell(new Phrase(objPropietario.strDepartamento, _standardFont));
                cldepa.BorderWidth = 0.5f;
                cldepa.BorderWidthBottom = 0.75f;
                cldepa.Colspan = 9;
                PdfPCell clmuni = new PdfPCell(new Phrase(objPropietario.strMunicipio, _standardFont));
                clmuni.BorderWidth = 0.5f;
                clmuni.BorderWidthBottom = 0.75f;
                clmuni.Colspan = 5;
                PdfPCell clnota = new PdfPCell(new Phrase(objPropietario.strEntidad, _standardFont));
                clnota.BorderWidth = 0.5f;
                clnota.BorderWidthBottom = 0.75f;
                clnota.Colspan = 6;
                tblPrueba.AddCell(clfecha);
                tblPrueba.AddCell(clregistro);
                tblPrueba.AddCell(clcausaactopro);
                tblPrueba.AddCell(clescri);
                tblPrueba.AddCell(cldepa);
                tblPrueba.AddCell(clmuni);
                tblPrueba.AddCell(clnota);
            }



         




            return tblPrueba;

        }
        public static ImpresionH Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImpresionH();

                return instance;
            }
        }
    }
}
