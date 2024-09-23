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
    class ImpresionG

    {
        private static ImpresionG instance = null;
        private ImpresionG()
        {

        }
        public iTextSharp.text.pdf.PdfPTable getTable(spFichaPredialesconsultar_Result objFichaJuridica)
        {

            iTextSharp.text.pdf.PdfPTable tblPrueba = new iTextSharp.text.pdf.PdfPTable(12);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font _titulo = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clnombre = new PdfPCell(new Phrase("INFORMACIÓN ANEXA", _titulo));
            clnombre.BorderWidth = 0.75f;
            clnombre.BorderWidthBottom = 0.75f;
            clnombre.Colspan = 12;

            PdfPCell cllavisitaprodujoinforme = new PdfPCell(new Phrase("La Visita Produjo Informe:", _standardFont));
            cllavisitaprodujoinforme.BorderWidth = 0.5f;
            cllavisitaprodujoinforme.BorderWidthBottom = 0.75f;
            cllavisitaprodujoinforme.Colspan = 4;

          
            

            PdfPCell clserelacionaplanoprotocolizado = new PdfPCell(new Phrase("Se Relaciona Plano Protocolizado:", _standardFont));
            clserelacionaplanoprotocolizado.BorderWidth = 0.5f;
            clserelacionaplanoprotocolizado.BorderWidthBottom = 0.75f;
            clserelacionaplanoprotocolizado.Colspan = 4;


            PdfPCell cldatosdelinforme = new PdfPCell(new Phrase("Número Carpeta:"+ objFichaJuridica.numero_carpeta , _standardFont));
            cldatosdelinforme.BorderWidth = 0.5f;
            cldatosdelinforme.BorderWidthBottom = 0.75f;
            cldatosdelinforme.Colspan = 4;






            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clnombre);
            tblPrueba.AddCell(cllavisitaprodujoinforme);
            tblPrueba.AddCell(clserelacionaplanoprotocolizado);
            tblPrueba.AddCell(cldatosdelinforme);


         

            return tblPrueba;
        }

        public static ImpresionG Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImpresionG();
                return instance;
            }
        }
    }
}

