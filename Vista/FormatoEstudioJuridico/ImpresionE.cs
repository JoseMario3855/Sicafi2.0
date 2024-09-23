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
    public class ImpresionE
    {
        private static ImpresionE instance = null;

        private ImpresionE()
        {

        }
        public iTextSharp.text.pdf.PdfPTable getTable(spFichaPredialesconsultar_Result objFichaJuridica)
        {

            iTextSharp.text.pdf.PdfPTable tblPrueba = new iTextSharp.text.pdf.PdfPTable(1);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font _titulo = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla

            PdfPCell clnombre = new PdfPCell(new Phrase("ESTUDIO JURIDICO DEL PREDIO ", _titulo));
            clnombre.BorderWidth = 0.5f;
            clnombre.BorderWidthBottom = 1;


            PdfPCell clantecedentes = new PdfPCell(new Phrase("Antecedentes:" + objFichaJuridica.antecedentes, _standardFont));
            clantecedentes.BorderWidth = 0.5f;
            clantecedentes.BorderWidthBottom = 1;
            clantecedentes.Colspan = 16;


            PdfPCell cldiferenciaareas = new PdfPCell(new Phrase("Diferencia Areas:"+ objFichaJuridica.razon_diferencia_areas, _standardFont));
            cldiferenciaareas.BorderWidth = 0.5f;
            cldiferenciaareas.BorderWidthBottom = 0.75f;
            cldiferenciaareas.Colspan = 13;

            PdfPCell clconceptojuridico = new PdfPCell(new Phrase("Concepto Juridico:"+objFichaJuridica.concepto_juridico, _standardFont));
            clconceptojuridico.BorderWidth = 0.5f;
            clconceptojuridico.BorderWidthBottom = 0.75f;
            

            PdfPCell cldocumentosanalizados = new PdfPCell(new Phrase("Documentos Analizados:"+ objFichaJuridica.documentos_analizados, _standardFont));
            cldocumentosanalizados.BorderWidth = 0.5f;
            cldocumentosanalizados.BorderWidthBottom = 0.75f;
            

            PdfPCell clsituacionjuridica = new PdfPCell(new Phrase("Situación Juridica :"+ objFichaJuridica.situacion_juridica_inmueble, _standardFont));
            clsituacionjuridica.BorderWidth = 0.5f;
            clsituacionjuridica.BorderWidthBottom = 0.75f;
            

            PdfPCell clobservacionessegunOvc = new PdfPCell(new Phrase("Observaciones con respeto a OVC:"+ objFichaJuridica.observaciones_con_respeto_al_propietario, _standardFont));
            clobservacionessegunOvc.BorderWidth = 0.5f;
            clobservacionessegunOvc.BorderWidthBottom = 0.75f;
            

            PdfPCell clanalisisdehechoyderecho = new PdfPCell(new Phrase("Analisis de hecho y derecho:"+ objFichaJuridica.analisis_de_hecho_y_derecho, _standardFont));
            clanalisisdehechoyderecho.BorderWidth = 0.5f;
            clanalisisdehechoyderecho.BorderWidthBottom = 0.75f;
           

            PdfPCell clanalisisdeareas = new PdfPCell(new Phrase("Analisis de areas :"+ objFichaJuridica.analisis_areas, _standardFont));
            clanalisisdeareas.BorderWidth = 0.5f;
            clanalisisdeareas.BorderWidthBottom = 0.75f;

            PdfPCell clanotacionqueafectelainscripcion = new PdfPCell(new Phrase("Anotación que afecta la inscripción :"+ objFichaJuridica.anotacion_que_afecta_la_inscripcion, _standardFont));
            clanotacionqueafectelainscripcion.BorderWidth = 0.5f;
            clanotacionqueafectelainscripcion.BorderWidthBottom = 0.75f;

            PdfPCell clproteccionColectiva = new PdfPCell(new Phrase("Protección Colectiva :"+ objFichaJuridica.proteccion_colectiva, _standardFont));
            clproteccionColectiva.BorderWidth = 0.5f;
            clproteccionColectiva.BorderWidthBottom = 0.75f;

            

            PdfPCell clinstruccionesvisitadecampo = new PdfPCell(new Phrase("Instrucciones Visita De Campo:"+ objFichaJuridica.instrucciones_visita_campo, _standardFont));
            clinstruccionesvisitadecampo.BorderWidth = 0.5f;
            clinstruccionesvisitadecampo.BorderWidthBottom = 0.75f;

            PdfPCell clrecomendaciones = new PdfPCell(new Phrase("Recomendaciones:"+ objFichaJuridica.recomendaciones, _standardFont));
            clrecomendaciones.BorderWidth = 0.5f;
            clrecomendaciones.BorderWidthBottom = 0.75f;

            PdfPCell clinformedecampo = new PdfPCell(new Phrase(" Datos de Informe de campo:" +objFichaJuridica.datos_informe_campo, _standardFont));
            clinformedecampo.BorderWidth = 0.5f;
            clinformedecampo.BorderWidthBottom = 0.75f;

            PdfPCell clnombrelinderos = new PdfPCell(new Phrase("LINDEROS ", _titulo));
            clnombrelinderos.BorderWidth = 0.5f;
            clnombrelinderos.BorderWidthBottom = 1;

            PdfPCell cllinderosescritura = new PdfPCell(new Phrase("Linderos Escritura:" + objFichaJuridica.linderos_escritura, _standardFont));
            cllinderosescritura.BorderWidth = 0.5f;
            cllinderosescritura.BorderWidthBottom = 0.75f;


            PdfPCell cllinderosfolio = new PdfPCell(new Phrase("Linderos Folio:" + objFichaJuridica.linderos_folio, _standardFont));
            cllinderosfolio.BorderWidth = 0.5f;
            cllinderosfolio.BorderWidthBottom = 0.75f;


            PdfPCell cllinderoscampo = new PdfPCell(new Phrase("Linderos Campo:" + objFichaJuridica.linderos_campo, _standardFont));
            cllinderoscampo.BorderWidth = 0.5f;
            cllinderoscampo.BorderWidthBottom = 0.75f;

            PdfPCell cllinderomasrelevantes = new PdfPCell(new Phrase("Lindero Más Relevantes:" + objFichaJuridica.linderos, _standardFont));
            cllinderomasrelevantes.BorderWidth = 0.5f;
            cllinderomasrelevantes.BorderWidthBottom = 0.75f;

            PdfPCell clnombrelinderos1 = new PdfPCell(new Phrase("LINDEROS SEGUN OVC ", _titulo));
            clnombrelinderos1.BorderWidth = 0.5f;
            clnombrelinderos1.BorderWidthBottom = 1;

            PdfPCell cllinderosnorte = new PdfPCell(new Phrase("Norte:" + objFichaJuridica.lindero_norte, _standardFont));
            cllinderosnorte.BorderWidth = 0.5f;
            cllinderosnorte.BorderWidthBottom = 0.75f;


            PdfPCell cllinderosSur = new PdfPCell(new Phrase("Sur:" + objFichaJuridica.lindero_sur, _standardFont));
            cllinderosSur.BorderWidth = 0.5f;
            cllinderosSur.BorderWidthBottom = 0.75f;


            PdfPCell cllinderosOccidente = new PdfPCell(new Phrase("Occidente:" + objFichaJuridica.lindero_occidente, _standardFont));
            cllinderosOccidente.BorderWidth = 0.5f;
            cllinderosOccidente.BorderWidthBottom = 0.75f;


            PdfPCell cllinderosoriente = new PdfPCell(new Phrase("Oriente:" + objFichaJuridica.lindero_oriente, _standardFont));
            cllinderosoriente.BorderWidth = 0.5f;
            cllinderosoriente.BorderWidthBottom = 0.75f;









            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clnombre);
            tblPrueba.AddCell(clantecedentes);
            tblPrueba.AddCell(cldiferenciaareas);
            tblPrueba.AddCell(clconceptojuridico);
            tblPrueba.AddCell(cldocumentosanalizados);
            tblPrueba.AddCell(clsituacionjuridica);
            tblPrueba.AddCell(clobservacionessegunOvc);
            tblPrueba.AddCell(clanalisisdehechoyderecho); 
            tblPrueba.AddCell(clanalisisdeareas);
            tblPrueba.AddCell(clanotacionqueafectelainscripcion);
            tblPrueba.AddCell(clproteccionColectiva);   
            tblPrueba.AddCell(clinstruccionesvisitadecampo);
            tblPrueba.AddCell(clrecomendaciones); 
            tblPrueba.AddCell(clinformedecampo);
            tblPrueba.AddCell(clnombrelinderos);
            tblPrueba.AddCell(cllinderosescritura);
            tblPrueba.AddCell(cllinderosfolio);
            tblPrueba.AddCell(cllinderoscampo);
            tblPrueba.AddCell(cllinderomasrelevantes);
            tblPrueba.AddCell(clnombrelinderos1);
            tblPrueba.AddCell(cllinderosnorte);
            tblPrueba.AddCell(cllinderosoriente);
            tblPrueba.AddCell(cllinderosSur);
            tblPrueba.AddCell(cllinderosOccidente);
            
           


            return tblPrueba;
        }

        public static ImpresionE Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImpresionE();
                return instance;
            }
        }
    }
}
