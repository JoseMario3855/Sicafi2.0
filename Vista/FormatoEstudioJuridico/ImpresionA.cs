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
    public class ImpresionA
    {

        private static ImpresionA instance = null;
        

        private ImpresionA()
        {

        }

        public iTextSharp.text.pdf.PdfPTable getTable(Consultar_Predio_Result objPredio, spFichaPredialesconsultar_Result objFichaJuridica)

        {
            
            iTextSharp.text.pdf.PdfPTable tblPrueba = new iTextSharp.text.pdf.PdfPTable(26);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL);
            
            iTextSharp.text.Font _titulo = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font _titulo1 = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLDITALIC);
            tblPrueba.WidthPercentage = 100;
            tblPrueba.DefaultCell.Border = Rectangle.NO_BORDER;


            // Configuramos el título de las columnas de la tabla
            PdfPCell cltitulo = new PdfPCell(new Phrase("ESTUDIO JURÍDICO DEL PREDIO PARA EL REGISTRO CATASTRAL DEL MUNICIPIO DE GÓMEZ PLATA",_titulo1));
            cltitulo.BorderWidth = 1;
            cltitulo.BorderWidthBottom =1;
            cltitulo.Colspan = 26;

            PdfPCell clnombre = new PdfPCell(new Phrase("DATOS FICHA PREDIAL",_titulo));
            clnombre.BorderWidth = 1;
            clnombre.BorderWidthBottom = 1;
            clnombre.Colspan = 26;

            PdfPCell clNumeroFicha = new PdfPCell(new Phrase("Numero Ficha:" + objPredio.strNumeroFicha, _titulo));
            clNumeroFicha.BorderWidth = 1;
            clNumeroFicha.BorderWidthBottom = 1;
            clNumeroFicha.Colspan = 8;

            PdfPCell clNumeroFichaOVC = new PdfPCell(new Phrase("Numero Ficha OVC:" + objFichaJuridica.numero_ficha_ovc, _titulo));
            clNumeroFichaOVC.BorderWidth = 1;
            clNumeroFichaOVC.BorderWidthBottom = 1;
            clNumeroFichaOVC.Colspan = 8;


            PdfPCell clnombremunicipio = new PdfPCell(new Phrase(("Nombre Municipio:")+objPredio.strDescripcionMunicipio, _standardFont));
            clnombremunicipio.BorderWidth = 0.5f;
            clnombremunicipio.BorderWidthBottom = 1;
            clnombremunicipio.Colspan = 10;

            PdfPCell clnombrecorregimiento = new PdfPCell(new Phrase("Nombre Corregimiento:" + objPredio.strDescripcionCorregimiento, _standardFont));
            clnombrecorregimiento.BorderWidth = 0.5f;
            clnombrecorregimiento.BorderWidthBottom = 1;
            clnombrecorregimiento.Colspan = 13;


            PdfPCell clnombrevereda = new PdfPCell(new Phrase("Nombre Vereda:" + objPredio.strDescripcionVereda, _standardFont));
            clnombrevereda.BorderWidth = 0.5f;
            clnombrevereda.BorderWidthBottom = 1;
            clnombrevereda.Colspan = 13;

            PdfPCell clCedulaCastral = new PdfPCell(new Phrase("Cedula Catastral:0"+05+objPredio.strMunicipio+objPredio.strSector+objPredio.strCorregimiento+objPredio.strBarrio+objPredio.strManzana+objPredio.strPredio+objPredio.strEdificio+objPredio.strUnidadPredial, _standardFont));
            clCedulaCastral.BorderWidth = 0.5f;
            clCedulaCastral.BorderWidthBottom = 1;
            clCedulaCastral.Colspan= 13;


            PdfPCell clsector = new PdfPCell(new Phrase("Sector:" + objPredio.strSector+ " "+ objFichaJuridica.descripicion_sector, _standardFont));
            clsector.BorderWidth = 0.5f;
            clsector.BorderWidthBottom = 1;
            clsector.Colspan = 6;

            PdfPCell cladquisicion = new PdfPCell(new Phrase("Adquisicion:" + objPredio.strModoAdquisicion+ " "+ objFichaJuridica.descripicion_adquisicion, _standardFont));
            cladquisicion.BorderWidth = 0.5f;
            cladquisicion.BorderWidthBottom = 1;
            cladquisicion.Colspan = 8;

            PdfPCell cldestino = new PdfPCell(new Phrase("Destino:" + objPredio.strDestinoEconomico + " " + objFichaJuridica.descripicion_destino, _standardFont));
            cldestino.BorderWidth = 0.5f;
            cldestino.BorderWidthBottom = 1;
            cldestino.Colspan = 7;

            PdfPCell clMatricula = new PdfPCell(new Phrase("Matricula:" + objPredio.strMatricula, _standardFont));
            clMatricula.BorderWidth = 0.5f;
            clMatricula.BorderWidthBottom = 1;
            clMatricula.Colspan = 5;



            PdfPCell cldireccionovc = new PdfPCell(new Phrase("Dirección OVC:" + objFichaJuridica.direccion_ovc, _standardFont));
            cldireccionovc.BorderWidth = 0.5f;
            cldireccionovc.BorderWidthBottom = 1;
            cldireccionovc.Colspan = 8;

            PdfPCell cldireccioncampo = new PdfPCell(new Phrase("Dirección Campo:" + objPredio.strDirreccion, _standardFont));
            cldireccioncampo.BorderWidth = 0.5f;
            cldireccioncampo.BorderWidthBottom = 1;
            cldireccioncampo.Colspan = 9;

            PdfPCell cldirecciofolio = new PdfPCell(new Phrase("Dirección Folio:" + objFichaJuridica.direccion_folio, _standardFont));
            cldirecciofolio.BorderWidth = 0.5f;
            cldirecciofolio.BorderWidthBottom = 1;
            cldirecciofolio.Colspan = 9;



           
            PdfPCell clubicacion = new PdfPCell(new Phrase("UBICACIÓN", _titulo));
            clubicacion.BorderWidth = 1;
            clubicacion.BorderWidthBottom = 1;
            clubicacion.Colspan = 26;


            PdfPCell clmpio = new PdfPCell(new Phrase("Municipio" , _titulo));
            clmpio.BorderWidth = 0.5f;
            clmpio.BorderWidthBottom = 1;
            clmpio.Colspan = 3;

            PdfPCell clsectoract = new PdfPCell(new Phrase("Sector", _titulo));
            clsectoract.BorderWidth = 0.5f;
            clsectoract.BorderWidthBottom = 1;
            clsectoract.Colspan = 3;

            PdfPCell clctgo = new PdfPCell(new Phrase("Corregimiento", _titulo));
            clctgo.BorderWidth = 0.5f;
            clctgo.BorderWidthBottom = 1;
            clctgo.Colspan = 4;

            PdfPCell clbr = new PdfPCell(new Phrase("Barrio", _titulo));
            clbr.BorderWidth = 0.5f;
            clbr.BorderWidthBottom = 1;
            clbr.Colspan = 3;

            PdfPCell clver = new PdfPCell(new Phrase("Manzana", _titulo));
            clver.BorderWidth = 0.5f;
            clver.BorderWidthBottom = 1;
            clver.Colspan = 3;

            PdfPCell clpredio = new PdfPCell(new Phrase("Predio", _titulo));
            clpredio.BorderWidth = 0.5f;
            clpredio.BorderWidthBottom = 1;
            clpredio.Colspan = 3;

            PdfPCell cled = new PdfPCell(new Phrase("Edificio", _titulo));
            cled.BorderWidth = 0.5f;
            cled.BorderWidthBottom = 1;
            cled.Colspan = 3;

            PdfPCell clup = new PdfPCell(new Phrase("Unidad Predial", _titulo));
            clup.BorderWidth = 0.5f;
            clup.BorderWidthBottom = 1;
            clup.Colspan = 5;


            PdfPCell cld1 = new PdfPCell(new Phrase(objPredio.strMunicipio, _standardFont));
            cld1.BorderWidth = 0.5f;
            cld1.BorderWidthBottom = 1;
            cld1.Colspan = 3;

            PdfPCell cld2 = new PdfPCell(new Phrase(objPredio.strSector, _standardFont));
            cld2.BorderWidth = 0.5f;
            cld2.BorderWidthBottom = 1;
            cld2.Colspan = 3;

            PdfPCell cld3 = new PdfPCell(new Phrase(objPredio.strCorregimiento, _standardFont));
            cld3.BorderWidth = 0.5f;
            cld3.BorderWidthBottom = 1;
            cld3.Colspan= 4;

            PdfPCell cld4 = new PdfPCell(new Phrase(objPredio.strBarrio, _standardFont));
            cld4.BorderWidth = 0.5f;
            cld4.BorderWidthBottom = 1;
            cld4.Colspan = 2;

            PdfPCell cld5 = new PdfPCell(new Phrase(objPredio.strManzana, _standardFont));
            cld5.BorderWidth = 0.5f;
            cld5.BorderWidthBottom = 1;
            cld5.Colspan = 3;

            PdfPCell cld6 = new PdfPCell(new Phrase(objPredio.strPredio, _standardFont));
            cld6.BorderWidth = 0.5f;
            cld6.BorderWidthBottom = 1;
            cld6.Colspan = 3;

            PdfPCell cld7 = new PdfPCell(new Phrase(objPredio.strEdificio, _standardFont));
            cld7.BorderWidth = 0.5f;
            cld7.BorderWidthBottom = 1;
            cld7.Colspan = 3;

            PdfPCell cld8 = new PdfPCell(new Phrase(objPredio.strUnidadPredial, _standardFont));
            cld8.BorderWidth = 0.5f;
            cld8.BorderWidthBottom = 1;
            cld8.Colspan = 5;

            PdfPCell cldatos = new PdfPCell(new Phrase("ÁREAS DEL PREDIO", _titulo));
            cldatos.BorderWidth = 1;
            cldatos.BorderWidthBottom = 1;
            cldatos.Colspan = 26;



            PdfPCell clarecampo = new PdfPCell(new Phrase("Area Campo:"+objPredio.strAreaTerreno+"  " +"M2", _standardFont));
            clarecampo.BorderWidth = 0.5f;
            clarecampo.BorderWidthBottom = 1;
            clarecampo.Colspan = 7;

            PdfPCell clareaovc = new PdfPCell(new Phrase("Área Ovc:" +objFichaJuridica.area_ovc + " "+ "M2", _standardFont));
            clareaovc.BorderWidth = 0.5f;
            clareaovc.BorderWidthBottom = 1;
            clareaovc.Colspan = 7;

            PdfPCell clareafolio = new PdfPCell(new Phrase("Área Folio:" +objFichaJuridica.area_folio + " " +"M2", _standardFont));
            clareafolio.BorderWidth = 0.5f;
            clareafolio.BorderWidthBottom = 1;
            clareafolio.Colspan = 6;

            PdfPCell clareaescritura = new PdfPCell(new Phrase("Área Escritura:" +objFichaJuridica.area_escritura+" "+"M2", _standardFont));
            clareaescritura.BorderWidth = 0.5f;
            clareaescritura.BorderWidthBottom = 1;
            clareaescritura.Colspan = 6;

            PdfPCell cldatos1 = new PdfPCell(new Phrase("INFORMACION JURIDICA", _titulo));
            cldatos1.BorderWidth = 1;
            cldatos1.BorderWidthBottom = 1;
            cldatos1.Colspan = 26;

            PdfPCell clinscripcionacatastro = new PdfPCell(new Phrase("Inscripción a catastro:", _standardFont));
            clinscripcionacatastro.BorderWidth = 0.5f;
            clinscripcionacatastro.BorderWidthBottom = 0.75f;
            clinscripcionacatastro.Colspan = 6;


            PdfPCell clantecedentesregistrales = new PdfPCell(new Phrase("Antecedentes Registrales:", _standardFont));
            clantecedentesregistrales.BorderWidth = 0.5f;
            clantecedentesregistrales.BorderWidthBottom = 0.75f;
            clantecedentesregistrales.Colspan = 6;

            PdfPCell clfoliomatriz = new PdfPCell(new Phrase("Folio Matriz:" + objFichaJuridica.folio_matriz, _standardFont));
            clfoliomatriz.BorderWidth = 0.5f;
            clfoliomatriz.BorderWidthBottom = 1;
            clfoliomatriz.Colspan = 7;

            PdfPCell clestado = new PdfPCell(new Phrase("Estado Folio Matriz:" , _standardFont));
            clestado.BorderWidth = 0.5f;
            clestado.BorderWidthBottom = 1;
            clestado.Colspan = 7;

            PdfPCell clestudiofoliomatriz = new PdfPCell(new Phrase("Estudio Folio Matriz:" +objFichaJuridica.estudio_folio_matriz, _standardFont));
            clestudiofoliomatriz.BorderWidth = 0.5f;
            clestudiofoliomatriz.BorderWidthBottom = 1;
            clestudiofoliomatriz.Colspan = 26;





            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(cltitulo);
            tblPrueba.AddCell(clnombre);
            tblPrueba.AddCell(clNumeroFicha);
            tblPrueba.AddCell(clNumeroFichaOVC);
            tblPrueba.AddCell(clnombremunicipio);
            tblPrueba.AddCell(clnombrecorregimiento);
            tblPrueba.AddCell(clnombrevereda);
            tblPrueba.AddCell(clCedulaCastral);  
            tblPrueba.AddCell(clsector);
            tblPrueba.AddCell(cladquisicion);
            tblPrueba.AddCell(cldestino);
            tblPrueba.AddCell(clMatricula);
            tblPrueba.AddCell(cldireccionovc);
            tblPrueba.AddCell(cldireccioncampo);
            tblPrueba.AddCell(cldirecciofolio);
            tblPrueba.AddCell(clubicacion);
            tblPrueba.AddCell(clmpio);
            tblPrueba.AddCell(clsectoract);
            tblPrueba.AddCell(clctgo);
            tblPrueba.AddCell(clbr);
            tblPrueba.AddCell(clver);
            tblPrueba.AddCell(clpredio);
            tblPrueba.AddCell(cled);
            tblPrueba.AddCell(clup);
            tblPrueba.AddCell(cld1);
            tblPrueba.AddCell(cld2);
            tblPrueba.AddCell(cld3);
            tblPrueba.AddCell(cld4);
            tblPrueba.AddCell(cld5);
            tblPrueba.AddCell(cld6);
            tblPrueba.AddCell(cld7);
            tblPrueba.AddCell(cld8);
            tblPrueba.AddCell(cldatos);
            tblPrueba.AddCell(clarecampo);
            tblPrueba.AddCell(clareaovc);
            tblPrueba.AddCell(clareafolio);
            tblPrueba.AddCell(clareaescritura);
            tblPrueba.AddCell(cldatos1);
            tblPrueba.AddCell(clinscripcionacatastro);
            tblPrueba.AddCell(clantecedentesregistrales);
            tblPrueba.AddCell(clfoliomatriz);
            tblPrueba.AddCell(clestado);
            tblPrueba.AddCell(clestudiofoliomatriz);

         


            return tblPrueba;
        }

        public static ImpresionA Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImpresionA();

                return instance;
            }
        }
    }



}

