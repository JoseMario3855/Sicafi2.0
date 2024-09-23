
using Datos.Sicafi.Listas;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text.html;
using Microsoft.VisualBasic;
using System.Web;
using System.Net.Http;
using System.Windows;
using System.Reflection;
using Datos.EstudioJuridico;

namespace Vista
{
    public partial class frmExportar : Form
    {
        frmFichaPredial objfrmFichaPredial;
        FichaPredialSicafi fichaPredialSicafi;
        public Consultar_Predio_Result objConsultarPredio;
        public spFichaPredialesconsultar_Result objFichaJuridica;
        public spFichaPredialesconsultar_Result objfichas;
        public spFichaPredialeHistoriaPropietariosconsultar_Result objhistoria;
        public spMatriculaDerivadasconsultar_Result objMatricula;


        public object Response { get; private set; }

        public frmExportar(frmFichaPredial objfrmFichaPredial)
        {

            this.objfrmFichaPredial = objfrmFichaPredial;
            this.fichaPredialSicafi = new FichaPredialSicafi(
               @"172.16.50.2\SQLEXPRESS"
               , "SICAFI"
               , "sa"
               , "conestudiosfame"
               ); ;
            InitializeComponent();
        }

        

        

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            
            List<Consultar_Predio_Result> lstFicha = fichaPredialSicafi.consultarFichaPredial(
                txtMunicipio.Text
                , txtSector.Text
                , txtCorregimiento.Text
                , txtBarrio.Text
                , txtManzana.Text
                , txtPredio.Text
                , txtEdificio.Text
                , txtUnidadPredial.Text,
                txtNumeroFicha.Text




                );
            if (lstFicha.Count < 1)
            {
                MessageBox.Show("El predio no esta en la base de datos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvExportar.DataSource = null;
            }
            else
            {
                dgvExportar.DataSource = lstFicha;
            }

           

        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {    
            /*
             if (dgvExportar.SelectedRows.Count > 0)
             {
                objfrmFichaPredial.objConsultarPredio = (Consultar_Predio_Result)dgvExportar.SelectedRows[0].DataBoundItem;
                Close();
             }
                else
                {
                     MessageBox.Show("Seleccione un predio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                */



            Consultar_Predio_Result objPredio = (Consultar_Predio_Result)dgvExportar.SelectedRows[0].DataBoundItem;
             List<Consultar_Propietario_Result> lstConsultarPropietario = fichaPredialSicafi.consultarPropietario(Convert.ToInt32(objPredio.strNumeroFicha));
             foreach (Consultar_Propietario_Result objPropietario in lstConsultarPropietario)
             {
               /*
                
                List<spFichaPredialPropietariosconsultar_Result> lstPropietarioJuridica = model.spFichaPredialPropietariosconsultar(objFichaJuridica.id_ficha, objPropietario.intIPropietario, null, null).ToList();
                if (lstPropietarioJuridica.Count > 0)
                 {
                  objPropietario.anotacion = (lstPropietarioJuridica[0].anotacion);
                        }
                         */
             }
            using (Datos.EstudioJuridico.Estudio_JuridicoEntities model = new Estudio_JuridicoEntities())
            {
                List<spFichaPredialesconsultar_Result> lstfichapredial = model.spFichaPredialesconsultar(objPredio.strNumeroFicha).ToList();
                if (lstfichapredial.Count > 0)
                {

                    objFichaJuridica = lstfichapredial[0];
                    List<Consultar_Propietario_Result> lstconsultar = fichaPredialSicafi.consultarPropietario(Convert.ToInt32(objPredio.strNumeroFicha));
                    objFichaJuridica = lstfichapredial[0];
                }

                List<Consultar_Propietario_Result> lstPropietarioJuridica = fichaPredialSicafi.consultarPropietario(Convert.ToInt32(objPredio.strNumeroFicha));
                    foreach (Consultar_Propietario_Result objPropietarioant in lstPropietarioJuridica)
                    {

                        List<spFichaPredialPropietariosconsultar_Result> lstanotacion = model.spFichaPredialPropietariosconsultar(objFichaJuridica.id_ficha, objPropietarioant.intIPropietario, null, null).ToList();
                        if (lstPropietarioJuridica.Count > 0)
                        {
                            objPropietarioant.anotacion = (lstanotacion[0].anotacion);

                        }


                        List<spFichaPredialeHistoriaPropietariosconsultar_Result> lsthistoriapropietario = model.spFichaPredialeHistoriaPropietariosconsultar(objFichaJuridica.id_ficha).ToList();
                        foreach(spFichaPredialeHistoriaPropietariosconsultar_Result objhistoria in lsthistoriapropietario)
                        {
                            List<spFichaPredialeHistoriaPropietariosconsultar_Result> lsthistoria = model.spFichaPredialeHistoriaPropietariosconsultar(objhistoria.id_ficha).ToList();
                            if (lsthistoriapropietario.Count > 0)
                            {

                                objhistoria.anotacion = (lsthistoria[0].anotacion);
                                objhistoria.causa_acto = (lsthistoria[0].causa_acto);
                                objhistoria.propietario = (lsthistoria[0].propietario);
                                objhistoria.titulo = (lsthistoria[0].titulo);
                                objhistoria.notaria = (lsthistoria[0].notaria);
                                objhistoria.fecha_escritura = (lsthistoria[0].fecha_escritura);
                                objhistoria.fecha_registro = (lsthistoria[0].fecha_registro);
                                objhistoria.area = (lsthistoria[0].area);
                                objhistoria.vendedor_anterior = (lsthistoria[0].vendedor_anterior);

                            }

                        List<spMatriculaDerivadasconsultar_Result> lstmatriculaderivada = model.spMatriculaDerivadasconsultar(objFichaJuridica.id_ficha, null, null, null, null).ToList();
                        foreach (spMatriculaDerivadasconsultar_Result objMatricula in lstmatriculaderivada)
                        {
                            List<spMatriculaDerivadasconsultar_Result> lstmatriculas = model.spMatriculaDerivadasconsultar(objMatricula.id_ficha, objMatricula.matricula, objMatricula.estado, objMatricula.pk_predio, objMatricula.ubicar).ToList();
                            if (lstmatriculas.Count >= 0)
                            {
                                objMatricula.matricula = (lstmatriculas[0].matricula);
                                objMatricula.estado = (lstmatriculas[0].estado);
                                objMatricula.pk_predio = (lstmatriculas[0].pk_predio);
                                objMatricula.ubicar = (lstmatriculas[0].ubicar);


                            }



                        }
                                Document doc = new Document(PageSize.LETTER);
                        UNCAccess uNCAccess = new UNCAccess();
                        uNCAccess.login(@"\\172.16.50.5\Actualizaciones_Catastrales\Informes Juridicos\", "administrador", "conestudios.local", "C0n3s1827Of234");
                                PdfWriter writer = PdfWriter.GetInstance(doc,
                                new FileStream(@"\\172.16.50.5\Actualizaciones_Catastrales\Informes Juridicos\"+objPredio.strMatricula+".PDF", FileMode.Create));
                                //Directory.CreateDirectory(@"D:\Estudio Juridico" + objPredio.strMatricula + ".pdf");//
                                doc.AddTitle("Mi Primer PDF");
                                doc.AddCreator("Conestudios");
                                doc.Open();
                        UNCAccess uNCAccess1 = new UNCAccess();
                        uNCAccess1.login(@"\\172.16.50.5\Actualizaciones_Catastrales\Informes Gomez Plata\", "administrador", "conestudios.local", "C0n3s1827Of234");
                        iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"\\172.16.50.5\Actualizaciones_Catastrales\Informes Juridicos\Logos\logos.png");
                                doc.Add(imagen);
                                /*doc.Add(new Paragraph("Estudio  Jurídico Del Predio Para El Registro Catastral Del Municipio de Gómez Plata "));
                                doc.Add(Chunk.NEWLINE);*/
                                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 8, iTextSharp.text.Font.STRIKETHRU);
                                //Instanciamos las clases 
                                doc.Add(FormatoEstudioJuridico.ImpresionA.Instance.getTable(objPredio, objFichaJuridica));
                                doc.Add(FormatoEstudioJuridico.ImpresionB.Instance.getTable(objPredio, lstConsultarPropietario, lstanotacion));
                                doc.Add(FormatoEstudioJuridico.ImpresionH.Instance.getTable(objPredio, lstConsultarPropietario));
                                doc.Add(FormatoEstudioJuridico.ImpresionC.Instance.getTable(lsthistoria, objFichaJuridica));
                                doc.Add(FormatoEstudioJuridico.ImpresionI.Instance.getTable(lsthistoria));
                                doc.Add(FormatoEstudioJuridico.ImpresionD.Instance.getTable(lstmatriculaderivada));
                                doc.Add(FormatoEstudioJuridico.ImpresionE.Instance.getTable(objFichaJuridica));
                                doc.Add(FormatoEstudioJuridico.ImpresionG.Instance.getTable(objFichaJuridica));
                                doc.Add(FormatoEstudioJuridico.ImpresionF.Instance.getTable(objFichaJuridica));
                                MessageBox.Show("PDF creado");
                                //doc.Close();//
                                writer.Close();
                       





                        
                        


                        }


                    }

            }


        }

        private void frmExportar_Load_1(object sender, EventArgs e)
        {
            dgvExportar.AutoGenerateColumns = false;
        }
    }
}

