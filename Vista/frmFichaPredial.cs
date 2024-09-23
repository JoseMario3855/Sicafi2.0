using Datos.EstudioJuridico;
using Datos.Sicafi.Listas;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmFichaPredial : Form
    {
        public Consultar_Predio_Result objConsultarPredio;

        public spFichaPredialesconsultar_Result objFichaJuridica;

        public frmFichaPredial()
        {
            InitializeComponent();
        }

        private void btnConsultarFicha_Click(object sender, EventArgs e)
        {
            frmConsultarFicha fr = new frmConsultarFicha(this);
            fr.ShowDialog();
            FichaPredialSicafi objFichaPredialSicafi = new FichaPredialSicafi(@"172.16.50.2\SQLEXPRESS"
               , "SICAFI"
               , "sa"
               , "conestudiosfame");
            if (objConsultarPredio != null)
            {

                txtFicha.Text = objConsultarPredio.strNumeroFicha;
                txtSector.Text = objConsultarPredio.strSector;
                txtMunicipio.Text = objConsultarPredio.strMunicipio;
                txtCorregimiento.Text = objConsultarPredio.strCorregimiento;
                txtBarrio.Text = objConsultarPredio.strBarrio;
                txtManzana.Text = objConsultarPredio.strManzana;
                txtPredio.Text = objConsultarPredio.strPredio;
                txtEdificio.Text = objConsultarPredio.strEdificio;
                txtUnidadPredial.Text = objConsultarPredio.strAntUnidadPredial;
                txtMatricula.Text = objConsultarPredio.strMatricula;
                txtAreaCampo.Text = objConsultarPredio.strAreaTerreno;
                txtAdquisicion.Text = objConsultarPredio.strModoAdquisicion;
                txtDireccionOvc.Text = objConsultarPredio.strDirreccion;
                txtNombreMunicipio.Text = objConsultarPredio.strDescripcionMunicipio;
                txtNombreCorregimiento.Text = objConsultarPredio.strDescripcionCorregimiento;
                txtNombreBarrio.Text = objConsultarPredio.strDescripcionBarrio;
                txtDestinoEconomico.Text = objConsultarPredio.strDestinoEconomico;
                txtNombreVereda.Text = objConsultarPredio.strDescripcionVereda;
                //txtDescripcionDestino.Text = objConsultarPredio.strDescripcion;//
                




                dgvPropietariosFolios.DataSource = null;
                dgvPropietarios.DataSource = null;
                txtFolioMatriz.Text = string.Empty;
                cbEstadoFolioMatriz.Checked = false;
                dtpFechaPrimeraAnotacion.Text = string.Empty;
                dtpFechaAperturaFolio.Text = string.Empty;
                txtAdquisicion.Text = string.Empty;
                txtAreaEscritura.Text = string.Empty;
                txtAreaFolio.Text = string.Empty;
                txtAreaOvc.Text = string.Empty;
              
                txtDireccionFolio.Text = string.Empty;
                txtRazonDiferenciaAreas.Text = string.Empty;
                txtAntecedentes.Text = string.Empty;
                txtEstudioFolioMatriz.Text = string.Empty;
                txtAnalisisAreas.Text = string.Empty;
                txtAnotacionqueafectelainscripcion.Text = string.Empty;
                txtProteccionColectiva.Text = string.Empty;
                txtLinderos.Text = string.Empty;
                txtInstruccionesVisitaCampo.Text = string.Empty;
                txtAprobacionInterventoria.Text = string.Empty;
                txtControCalidadJuridico.Text = string.Empty;
                txtQuienElaboroYAprobo.Text = string.Empty;
                txtAprobacionInterventoria.Text = string.Empty;
                dgvMatriculaDerivadas.DataSource = null;
                cbAntecedentesRegistrales.Checked = false;
                cbInscripcionCatastro.Checked = false;
                cbSeRelacionaPlanoEnLaEscritura.Checked = false;
                txtFolioMatriz.Text = string.Empty;
                txtPkpredioFolioMatriz.Text = string.Empty;
                txtDireccionSegunOVC.Text = string.Empty;
                txtComplementacion.Text = string.Empty;
                txtObservacionesConRespetoAlPropietarioOVC.Text = string.Empty;
                cbSeDiligencioFichaPredial.Checked = false;
                cbLaVisitaDeCampoProdujoInforme.Checked = false;
                cbSeLevantoActaDeColindacia.Checked = false;
                txtSituacionJuridicaDelInmueble.Text = string.Empty;
                txtDocumentosAnalizados.Text = string.Empty;
                txtNumeroCarpeta.Text = string.Empty;
                txtTarjetaProfesional.Text = string.Empty;
                txtCoordinadorJuridico.Text = string.Empty;
                txtNombreInterventor.Text = string.Empty;
                txtLinderosCampo.Text = string.Empty;
                txtLinderosFolio.Text = string.Empty;
                txtLinderosEscritura.Text = string.Empty;
                txtNorte.Text = string.Empty;
                txtOccidente.Text = string.Empty;
                txtOriente.Text = string.Empty;
                txtSur.Text = string.Empty;
                txtDescripcionDestino.Text = string.Empty;
                txtDescripcionSector.Text = string.Empty;
                txtDescripcionAdquisicion.Text = string.Empty;
                txtInforme.Text = string.Empty;



                using (Datos.EstudioJuridico.Estudio_JuridicoEntities model = new Estudio_JuridicoEntities())
                {
                    List<spFichaPredialesconsultar_Result> lstFichaPredial = model.spFichaPredialesconsultar(objConsultarPredio.strNumeroFicha).ToList();
                    if (lstFichaPredial.Count > 0)
                    {
                        objFichaJuridica = lstFichaPredial[0];
                        txtDireccionFolio.Text = objFichaJuridica.direccion_folio;
                        txtFolioMatriz.Text = objFichaJuridica.folio_matriz;
                        cbEstadoFolioMatriz.Checked = Convert.ToBoolean(objFichaJuridica.estado_folio_matriz);
                        txtAreaEscritura.Text = Convert.ToString(objFichaJuridica.area_escritura);
                        txtAreaFolio.Text = Convert.ToString(objFichaJuridica.area_folio);
                        txtAreaOvc.Text = Convert.ToString(objFichaJuridica.area_ovc);
                        txtRazonDiferenciaAreas.Text = objFichaJuridica.razon_diferencia_areas;
                        txtAntecedentes.Text = objFichaJuridica.antecedentes;
                        txtEstudioFolioMatriz.Text = objFichaJuridica.estudio_folio_matriz;
                        txtAnalisisAreas.Text = objFichaJuridica.analisis_areas;
                        txtAnotacionqueafectelainscripcion.Text = objFichaJuridica.anotacion_que_afecta_la_inscripcion;
                        txtProteccionColectiva.Text = objFichaJuridica.proteccion_colectiva;
                        txtLinderos.Text = objFichaJuridica.linderos;
                        txtInstruccionesVisitaCampo.Text = objFichaJuridica.instrucciones_visita_campo;
                        txtControCalidadJuridico.Text = objFichaJuridica.control_calidad_juridico;
                        txtQuienElaboroYAprobo.Text = objFichaJuridica.quien_elaboro_yaprobo;
                        txtAprobacionInterventoria.Text = objFichaJuridica.aprobacion_interventoria;
                        dtpFechaAperturaFolio.Value = Convert.ToDateTime(objFichaJuridica.fecha_apertura_folio);
                        dtpFechaPrimeraAnotacion.Value = Convert.ToDateTime(objFichaJuridica.fecha_primera_anotacion);
                        dtpFechaControlCalidadJuridico.Value = Convert.ToDateTime(objFichaJuridica.fecha_control_calidad_juridico);
                        dtpFechaAprobacion.Value = Convert.ToDateTime(objFichaJuridica.fecha_aprobacion);
                        txtComplementacion.Text = objFichaJuridica.complementacion;
                        txtDepartamento.Text = objFichaJuridica.codigo_municipio;
                        txtDescripcionDepartamento.Text = objFichaJuridica.descripcion_municipio;
                        txtLinderosEscritura.Text = objFichaJuridica.linderos_escritura;
                        txtLinderosFolio.Text = objFichaJuridica.linderos_folio;
                        txtLinderosCampo.Text = objFichaJuridica.linderos_campo;
                        txtAnalisisDeHechoYDerecho.Text = objFichaJuridica.analisis_de_hecho_y_derecho;
                        cbInscripcionCatastro.Checked = Convert.ToBoolean(objFichaJuridica.inscripcion_catastro);
                        cbAntecedentesRegistrales.Checked = Convert.ToBoolean(objFichaJuridica.antecedentes_registrales);
                        txtConceptoJuridico.Text = objFichaJuridica.concepto_juridico;
                        txtRecomendaciones.Text = objFichaJuridica.recomendaciones;
                        txtDocumentosAnalizados.Text = objFichaJuridica.documentos_analizados;
                        txtNorte.Text = objFichaJuridica.lindero_norte;
                        txtOccidente.Text = objFichaJuridica.lindero_occidente;
                        txtOriente.Text = objFichaJuridica.lindero_oriente;
                        txtSur.Text = objFichaJuridica.lindero_sur;
                        txtPkpredioFolioMatriz.Text = objFichaJuridica.pk_predio_folio_matriz;
                        txtDireccionSegunOVC.Text = objFichaJuridica.direccion_ovc;
                        cbSeRelacionaPlanoEnLaEscritura.Checked = Convert.ToBoolean(objFichaJuridica.enla_escritura_se_relaciona_plano_protocolizado);
                        txtObservacionesConRespetoAlPropietarioOVC.Text = objFichaJuridica.observaciones_con_respeto_al_propietario;
                        cbSeDiligencioFichaPredial.Checked = Convert.ToBoolean(objFichaJuridica.se_diligencio_ficha_predial);
                        cbSeLevantoActaDeColindacia.Checked = Convert.ToBoolean(objFichaJuridica.se_levanto_acta_de_colindacia);
                        cbLaVisitaDeCampoProdujoInforme.Checked = Convert.ToBoolean(objFichaJuridica.la_visita_de_campo_produjo_informe);
                        txtSituacionJuridicaDelInmueble.Text = objFichaJuridica.situacion_juridica_inmueble;
                        txtNumeroCarpeta.Text = objFichaJuridica.numero_carpeta;
                        txtTarjetaProfesional.Text = objFichaJuridica.tarjeta_profesional_juridico;
                        txtCoordinadorJuridico.Text = objFichaJuridica.coordinador_juridico;
                        txtNombreInterventor.Text = objFichaJuridica.nombre_interventor;
                        txtDescripcionDestino.Text = objFichaJuridica.descripicion_destino;
                        txtDescripcionSector.Text = objFichaJuridica.descripicion_sector;
                        txtDescripcionAdquisicion.Text = objFichaJuridica.descripicion_adquisicion;
                        txtInforme.Text = objFichaJuridica.datos_informe_campo;
                        txtNumeroFichaOVC.Text = objFichaJuridica.numero_ficha_ovc;







                        List<spMatriculaDerivadasconsultar_Result> lstMatriculasResultantes = model.spMatriculaDerivadasconsultar(objFichaJuridica.id_ficha, null, null, null, null).ToList();
                        if (lstMatriculasResultantes.Count > 0)
                        {
                            dgvMatriculaDerivadas.DataSource = lstMatriculasResultantes;
                        }
                        List<Consultar_Propietario_Result> lstConsultarPropietario = objFichaPredialSicafi.consultarPropietario(Convert.ToInt32(objConsultarPredio.strNumeroFicha));
                        foreach (Consultar_Propietario_Result objPropietario in lstConsultarPropietario)
                        {

                            List<spFichaPredialPropietariosconsultar_Result> lstPropietarioJuridica = model.spFichaPredialPropietariosconsultar(objFichaJuridica.id_ficha, objPropietario.intIPropietario, null, null).ToList();
                            if (lstPropietarioJuridica.Count > 0)
                            {
                                objPropietario.anotacion = (lstPropietarioJuridica[0].anotacion);
                            }

                        }
                        dgvPropietarios.DataSource = lstConsultarPropietario;
                        List<spFichaPredialeHistoriaPropietariosconsultar_Result> lsthistoriapropietario = model.spFichaPredialeHistoriaPropietariosconsultar(objFichaJuridica.id_ficha).ToList();
                        if (lsthistoriapropietario.Count > 0)
                        {
                            dgvPropietariosFolios.DataSource = lsthistoriapropietario;
                        }

                    }
                    else
                    {
                        objFichaJuridica = null;
                        List<Consultar_Propietario_Result> lstConsultarPropietario = objFichaPredialSicafi.consultarPropietario(Convert.ToInt32(objConsultarPredio.strNumeroFicha));
                        dgvPropietarios.DataSource = lstConsultarPropietario;
                    }
                }

            }


        }

        private void btnAgregarAnotacion_Click(object sender, EventArgs e)
        {
            if (dgvPropietarios.SelectedRows.Count > 0)
            {
                frmAgregarAnotacion fr = new frmAgregarAnotacion(this);
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un propietario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void limpiar()
        {
            txtFicha.Text = string.Empty;

            txtSector.Text = string.Empty;
            txtMunicipio.Text = string.Empty;
            txtCorregimiento.Text = string.Empty;
            txtBarrio.Text = string.Empty;
            txtManzana.Text = string.Empty;
            txtPredio.Text = string.Empty;
            txtEdificio.Text = string.Empty;
            txtUnidadPredial.Text = string.Empty;
            dgvPropietarios.DataSource = null;
            txtMatricula.Text = string.Empty;
            txtFolioMatriz.Text = string.Empty;
            cbEstadoFolioMatriz.Checked = false;
            dtpFechaPrimeraAnotacion.Text = string.Empty;
            dtpFechaAperturaFolio.Text = string.Empty;
            txtAdquisicion.Text = string.Empty;
            txtAreaEscritura.Text = string.Empty;
            txtAreaFolio.Text = string.Empty;
            txtAreaOvc.Text = string.Empty;
            txtAreaCampo.Text = string.Empty;
            txtDireccionFolio.Text = string.Empty;
            txtRazonDiferenciaAreas.Text = string.Empty;
            txtAntecedentes.Text = string.Empty;
            txtEstudioFolioMatriz.Text = string.Empty;
            txtAnalisisAreas.Text = string.Empty;
            txtAnotacionqueafectelainscripcion.Text = string.Empty;
            txtProteccionColectiva.Text = string.Empty;
            txtLinderos.Text = string.Empty;
            txtInstruccionesVisitaCampo.Text = string.Empty;
            txtAprobacionInterventoria.Text = string.Empty;
            txtControCalidadJuridico.Text = string.Empty;
            txtQuienElaboroYAprobo.Text = string.Empty;
            txtAprobacionInterventoria.Text = string.Empty;
            dgvMatriculaDerivadas.DataSource = null;
            txtDepartamento.Text = string.Empty;
            txtNombreVereda.Text = string.Empty;
            txtNombreMunicipio.Text = string.Empty;
            txtNombreBarrio.Text = string.Empty;
            txtNombreCorregimiento.Text = string.Empty;
            txtDireccionOvc.Text = string.Empty;
            txtDescripcionDepartamento.Text = string.Empty;
            txtSector.Text = string.Empty;
            txtAdquisicion.Text = string.Empty;
            txtDestinoEconomico.Text = string.Empty;
            cbAntecedentesRegistrales.Checked = false;
            cbInscripcionCatastro.Checked = false;
            cbSeRelacionaPlanoEnLaEscritura.Checked = false;
            txtFolioMatriz.Text = string.Empty;
            txtPkpredioFolioMatriz.Text = string.Empty;
            txtDireccionSegunOVC.Text = string.Empty;
            txtComplementacion.Text = string.Empty;
            txtObservacionesConRespetoAlPropietarioOVC.Text = string.Empty;
            cbSeDiligencioFichaPredial.Checked = false;
            cbLaVisitaDeCampoProdujoInforme.Checked = false;
            cbSeLevantoActaDeColindacia.Checked = false;
            txtSituacionJuridicaDelInmueble.Text = string.Empty;
            txtDocumentosAnalizados.Text = string.Empty;
            txtNumeroCarpeta.Text = string.Empty;
            txtTarjetaProfesional.Text = string.Empty;
            txtCoordinadorJuridico.Text = string.Empty;
            txtNombreInterventor.Text = string.Empty;
            txtLinderosCampo.Text = string.Empty;
            txtLinderosFolio.Text = string.Empty;
            txtLinderosEscritura.Text = string.Empty;
            txtNorte.Text = string.Empty;
            txtOccidente.Text = string.Empty;
            txtOriente.Text = string.Empty;
            txtSur.Text = string.Empty;
            txtDescripcionDestino.Text = string.Empty;
            txtDescripcionSector.Text = string.Empty;
            txtDescripcionAdquisicion.Text = string.Empty;
            txtInforme.Text = string.Empty;
            dgvPropietariosFolios.DataSource = null;
            txtConceptoJuridico.Text = string.Empty;
            txtCoordinadorJuridico.Text = string.Empty;
            txtNumeroFichaOVC.Text = string.Empty;





            tbcEstudioJuridico.SelectedIndex = 0;





        }

        private void frmFichaPredial_Load(object sender, EventArgs e)
        {
            dgvPropietarios.AutoGenerateColumns = false;
            dgvMatriculaDerivadas.AutoGenerateColumns = false;
        }

        private void btnAgregarMatricula_Click(object sender, EventArgs e)
        {
            frmAgregarMatriculaDerivada frm = new frmAgregarMatriculaDerivada(this);
            frm.ShowDialog();
        }

        private void btnEliminarMatricula_Click(object sender, EventArgs e)
        {
            if (dgvMatriculaDerivadas.SelectedRows.Count > 0)
            {
                spMatriculaDerivadasconsultar_Result obj = (spMatriculaDerivadasconsultar_Result)dgvMatriculaDerivadas.SelectedRows[0].DataBoundItem;
                List<spMatriculaDerivadasconsultar_Result> lst = (List<spMatriculaDerivadasconsultar_Result>)dgvMatriculaDerivadas.DataSource;
                lst.Remove(obj);
                dgvMatriculaDerivadas.DataSource = null;
                dgvMatriculaDerivadas.DataSource = lst;
            }
            else
            {
                MessageBox.Show("Seleccione un campo de la grid", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(dtpFechaPrimeraAnotacion.Text))
            {
                MessageBox.Show("Debe ingresar la Fecha de la primera anotación", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(dtpFechaAperturaFolio.Text))
            {
                MessageBox.Show("Debe ingresar la Fecha de apertura del folio ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtAreaEscritura.Text))
            {
                MessageBox.Show("Debe ingresar el area de escritura ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtAreaOvc.Text))
            {
                MessageBox.Show("Debe ingresar el area de ovc", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtAreaFolio.Text))
            {
                MessageBox.Show("Debe ingresar el area del folio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtRazonDiferenciaAreas.Text))
            {
                MessageBox.Show("Debe ingresar la razon de diferencias de areas ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtAntecedentes.Text))
            {
                MessageBox.Show("Debe ingresr los antecedentes del predio ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtAnalisisAreas.Text))
            {
                MessageBox.Show("Debe ingresar el analisis de areas ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtAnotacionqueafectelainscripcion.Text))
            {
                MessageBox.Show("Debe ingresar la anotacioón que afecte la inscripcion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtProteccionColectiva.Text))
            {
                MessageBox.Show("Debe ingresar la proteccion colectiva ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtLinderos.Text))
            {
                MessageBox.Show("Debe ingresar la  cabida y linderos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtInstruccionesVisitaCampo.Text))
            {
                MessageBox.Show("ingrese las instrucciones para la visita de campo ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (objConsultarPredio != null)
                {
                    if (objFichaJuridica == null)
                    {
                        objFichaJuridica = new spFichaPredialesconsultar_Result();
                        objFichaJuridica.id_ficha = 0;
                    }
                    using (Datos.EstudioJuridico.Estudio_JuridicoEntities model = new Estudio_JuridicoEntities())
                    {
                        objFichaJuridica.analisis_areas = txtAnalisisAreas.Text;
                        objFichaJuridica.anotacion_que_afecta_la_inscripcion = txtAnotacionqueafectelainscripcion.Text;
                        objFichaJuridica.antecedentes = txtAntecedentes.Text;
                        objFichaJuridica.area_escritura = Convert.ToDecimal(txtAreaEscritura.Text);
                        objFichaJuridica.area_ovc = Convert.ToDecimal(txtAreaOvc.Text);
                        objFichaJuridica.area_folio = Convert.ToDecimal(txtAreaFolio.Text);
                        objFichaJuridica.area_ovc = Convert.ToDecimal(txtAreaOvc.Text);
                        objFichaJuridica.proteccion_colectiva = txtProteccionColectiva.Text;
                        objFichaJuridica.numero_ficha = txtFicha.Text;
                        objFichaJuridica.instrucciones_visita_campo = txtInstruccionesVisitaCampo.Text;
                        objFichaJuridica.linderos = txtLinderos.Text;
                        objFichaJuridica.ruta_archivo = String.Empty;
                        objFichaJuridica.estudio_folio_matriz = txtEstudioFolioMatriz.Text;
                        // Si el checkBox esta chuleado es por que esta cerrado//
                        objFichaJuridica.estado_folio_matriz = cbEstadoFolioMatriz.Checked;
                        objFichaJuridica.razon_diferencia_areas = txtRazonDiferenciaAreas.Text;
                        objFichaJuridica.folio_matriz = txtFolioMatriz.Text;
                        objFichaJuridica.direccion_folio = txtDireccionFolio.Text;
                        objFichaJuridica.quien_elaboro_yaprobo = txtQuienElaboroYAprobo.Text;
                        objFichaJuridica.aprobacion_interventoria = txtAprobacionInterventoria.Text;
                        objFichaJuridica.control_calidad_juridico = txtControCalidadJuridico.Text;
                        objFichaJuridica.fecha_apertura_folio = dtpFechaAperturaFolio.Value;
                        objFichaJuridica.fecha_primera_anotacion = dtpFechaPrimeraAnotacion.Value;
                        objFichaJuridica.fecha_control_calidad_juridico = dtpFechaControlCalidadJuridico.Value;
                        objFichaJuridica.fecha_aprobacion = dtpFechaAprobacion.Value;
                        objFichaJuridica.linderos_escritura = txtLinderosEscritura.Text;
                        objFichaJuridica.linderos_folio = txtLinderosFolio.Text;
                        objFichaJuridica.linderos_campo = txtLinderosCampo.Text;
                        objFichaJuridica.analisis_de_hecho_y_derecho = txtAnalisisDeHechoYDerecho.Text;
                        // Si el checkBox esta chuleado es por que tiene inscripción a catastro//
                        objFichaJuridica.inscripcion_catastro = cbInscripcionCatastro.Checked;
                        // Si el checkBox esta chuleado es por que tiene antecedentes registrales//
                        objFichaJuridica.antecedentes_registrales = cbAntecedentesRegistrales.Checked;
                        objFichaJuridica.concepto_juridico = txtConceptoJuridico.Text;
                        objFichaJuridica.recomendaciones = txtRecomendaciones.Text;
                        objFichaJuridica.documentos_analizados = txtDocumentosAnalizados.Text;
                        objFichaJuridica.lindero_norte = txtNorte.Text;
                        objFichaJuridica.lindero_occidente = txtOccidente.Text;
                        objFichaJuridica.lindero_oriente = txtOriente.Text;
                        objFichaJuridica.lindero_sur = txtSur.Text;
                        objFichaJuridica.pk_predio_folio_matriz = txtPkpredioFolioMatriz.Text;
                        objFichaJuridica.direccion_ovc = txtDireccionSegunOVC.Text;
                        objFichaJuridica.enla_escritura_se_relaciona_plano_protocolizado = cbSeRelacionaPlanoEnLaEscritura.Checked;
                        objFichaJuridica.observaciones_con_respeto_al_propietario = txtObservacionesConRespetoAlPropietarioOVC.Text;
                        objFichaJuridica.se_diligencio_ficha_predial = cbSeDiligencioFichaPredial.Checked;
                        objFichaJuridica.la_visita_de_campo_produjo_informe = cbLaVisitaDeCampoProdujoInforme.Checked;
                        objFichaJuridica.se_levanto_acta_de_colindacia = cbSeLevantoActaDeColindacia.Checked;
                        objFichaJuridica.situacion_juridica_inmueble = txtSituacionJuridicaDelInmueble.Text;
                        objFichaJuridica.numero_carpeta = txtNumeroCarpeta.Text;
                        objFichaJuridica.tarjeta_profesional_juridico = txtTarjetaProfesional.Text;
                        objFichaJuridica.coordinador_juridico = txtCoordinadorJuridico.Text;
                        objFichaJuridica.nombre_interventor = txtNombreInterventor.Text;
                        objFichaJuridica.descripcion_municipio = txtDescripcionDepartamento.Text;
                        objFichaJuridica.codigo_municipio = txtDepartamento.Text;
                        objFichaJuridica.complementacion = txtComplementacion.Text;
                        objFichaJuridica.descripicion_destino = txtDescripcionDestino.Text;
                        objFichaJuridica.descripicion_sector = txtDescripcionSector.Text;
                        objFichaJuridica.descripicion_adquisicion = txtDescripcionAdquisicion.Text;
                        objFichaJuridica.datos_informe_campo = txtInforme.Text;
                        objFichaJuridica.coordinador_juridico = txtCoordinadorJuridico.Text;
                        objFichaJuridica.numero_ficha_ovc = txtNumeroFichaOVC.Text;

                       




                        /*Guarda*/
                        if (objFichaJuridica.id_ficha == 0)
                        {
                            decimal? id = model.spFichaPredialescrear(objFichaJuridica.numero_ficha, objFichaJuridica.folio_matriz, objFichaJuridica.estado_folio_matriz, objFichaJuridica.fecha_apertura_folio, objFichaJuridica.fecha_primera_anotacion,
                            objFichaJuridica.area_escritura, objFichaJuridica.area_ovc, objFichaJuridica.area_folio, objFichaJuridica.ruta_archivo,
                            objFichaJuridica.razon_diferencia_areas, objFichaJuridica.antecedentes, objFichaJuridica.estudio_folio_matriz, objFichaJuridica.analisis_areas, objFichaJuridica.anotacion_que_afecta_la_inscripcion,
                            objFichaJuridica.proteccion_colectiva, objFichaJuridica.linderos, objFichaJuridica.instrucciones_visita_campo, objFichaJuridica.direccion_folio, objFichaJuridica.quien_elaboro_yaprobo, objFichaJuridica.fecha_control_calidad_juridico, objFichaJuridica.control_calidad_juridico,
                            objFichaJuridica.aprobacion_interventoria, objFichaJuridica.fecha_aprobacion, objFichaJuridica.linderos_escritura, objFichaJuridica.linderos_folio, objFichaJuridica.linderos_campo,
                            objFichaJuridica.analisis_de_hecho_y_derecho, objFichaJuridica.inscripcion_catastro, objFichaJuridica.antecedentes_registrales, objFichaJuridica.concepto_juridico, objFichaJuridica.recomendaciones,
                            objFichaJuridica.documentos_analizados, objFichaJuridica.lindero_norte, objFichaJuridica.lindero_occidente, objFichaJuridica.lindero_oriente, objFichaJuridica.lindero_sur, objFichaJuridica.pk_predio_folio_matriz,
                            objFichaJuridica.direccion_ovc, objFichaJuridica.enla_escritura_se_relaciona_plano_protocolizado, objFichaJuridica.complementacion, objFichaJuridica.observaciones_con_respeto_al_propietario, objFichaJuridica.se_diligencio_ficha_predial, objFichaJuridica.la_visita_de_campo_produjo_informe,
                            objFichaJuridica.se_levanto_acta_de_colindacia, objFichaJuridica.situacion_juridica_inmueble, objFichaJuridica.numero_carpeta, objFichaJuridica.tarjeta_profesional_juridico, objFichaJuridica.coordinador_juridico,
                            objFichaJuridica.nombre_interventor, objFichaJuridica.codigo_municipio, objFichaJuridica.descripcion_municipio,objFichaJuridica.datos_informe_juridico,objFichaJuridica.datos_informe_campo,objFichaJuridica.descripicion_destino,
                            objFichaJuridica.descripicion_sector, objFichaJuridica.descripicion_adquisicion,objFichaJuridica.numero_ficha_ovc);



                            EstudiosJuridicos objestudiosJuridicos = new EstudiosJuridicos();


                            objFichaJuridica.id_ficha = objestudiosJuridicos.consultar_idficha(objFichaJuridica.numero_ficha);
                        }
                        else
                        {
                            model.spFichaPredialesmodificar(objFichaJuridica.id_ficha, objFichaJuridica.folio_matriz, objFichaJuridica.estado_folio_matriz, objFichaJuridica.fecha_apertura_folio,
                                objFichaJuridica.fecha_primera_anotacion, objFichaJuridica.area_escritura, objFichaJuridica.area_ovc, objFichaJuridica.area_folio, objFichaJuridica.ruta_archivo,
                                objFichaJuridica.razon_diferencia_areas, objFichaJuridica.antecedentes, objFichaJuridica.estudio_folio_matriz, objFichaJuridica.analisis_areas, objFichaJuridica.anotacion_que_afecta_la_inscripcion,
                                objFichaJuridica.proteccion_colectiva, objFichaJuridica.linderos, objFichaJuridica.instrucciones_visita_campo, objFichaJuridica.direccion_folio, objFichaJuridica.quien_elaboro_yaprobo,
                                objFichaJuridica.fecha_control_calidad_juridico, objFichaJuridica.control_calidad_juridico, objFichaJuridica.aprobacion_interventoria, objFichaJuridica.fecha_aprobacion, objFichaJuridica.linderos_escritura, objFichaJuridica.linderos_folio, objFichaJuridica.linderos_campo,
                                objFichaJuridica.analisis_de_hecho_y_derecho, objFichaJuridica.inscripcion_catastro, objFichaJuridica.antecedentes_registrales, objFichaJuridica.concepto_juridico, objFichaJuridica.recomendaciones,
                                objFichaJuridica.documentos_analizados, objFichaJuridica.lindero_norte, objFichaJuridica.lindero_occidente, objFichaJuridica.lindero_oriente, objFichaJuridica.lindero_sur, objFichaJuridica.pk_predio_folio_matriz,
                                objFichaJuridica.direccion_ovc, objFichaJuridica.enla_escritura_se_relaciona_plano_protocolizado, objFichaJuridica.complementacion, objFichaJuridica.observaciones_con_respeto_al_propietario, objFichaJuridica.se_diligencio_ficha_predial, objFichaJuridica.la_visita_de_campo_produjo_informe,
                                objFichaJuridica.se_levanto_acta_de_colindacia, objFichaJuridica.situacion_juridica_inmueble, objFichaJuridica.numero_carpeta, objFichaJuridica.tarjeta_profesional_juridico, objFichaJuridica.coordinador_juridico,
                                objFichaJuridica.nombre_interventor, objFichaJuridica.codigo_municipio, objFichaJuridica.descripcion_municipio, objFichaJuridica.datos_informe_juridico, objFichaJuridica.datos_informe_campo, objFichaJuridica.descripicion_destino,
                            objFichaJuridica.descripicion_sector, objFichaJuridica.descripicion_adquisicion, objFichaJuridica.numero_ficha_ovc);
                        }


                        foreach (DataGridViewRow row in dgvPropietarios.Rows)
                        {
                            Consultar_Propietario_Result objPropietario = (Consultar_Propietario_Result)row.DataBoundItem;
                            List<spFichaPredialPropietariosconsultar_Result> lstPropietarioJuridica = model.spFichaPredialPropietariosconsultar(objFichaJuridica.id_ficha, objPropietario.intIPropietario, null, null).ToList();
                            if (lstPropietarioJuridica.Count > 0)
                            {
                                model.spFichaPredialPropietariosmodificar(lstPropietarioJuridica[0].id_ficha_perdial_propietario
                                                                        , lstPropietarioJuridica[0].id_propietario
                                                                        , objPropietario.anotacion);
                            }
                            else
                            {
                                model.spFichaPredialPropietarioscrear(objFichaJuridica.id_ficha
                                                                        , objPropietario.intIPropietario
                                                                        , objPropietario.anotacion);
                            }
                        }
                        model.spMatriculaDerivadaseliminar(objFichaJuridica.id_ficha);
                        foreach (DataGridViewRow row in dgvMatriculaDerivadas.Rows)
                        {
                            spMatriculaDerivadasconsultar_Result objMatriculaDerivada = (spMatriculaDerivadasconsultar_Result)row.DataBoundItem;
                            model.spMatriculaDerivadascrear(
                                    objFichaJuridica.id_ficha
                                    , objMatriculaDerivada.matricula
                                    , objMatriculaDerivada.estado
                                    , objMatriculaDerivada.pk_predio
                                    , objMatriculaDerivada.ubicar
                                );
                        }
                        model.spFichaPredialHistoriaPropietarioseliminar(objFichaJuridica.id_ficha);
                        foreach(DataGridViewRow row in dgvPropietariosFolios.Rows)
                        {
                            spFichaPredialeHistoriaPropietariosconsultar_Result objPropietarios = (spFichaPredialeHistoriaPropietariosconsultar_Result)row.DataBoundItem;
                            model.spFichaPredialeHistoriaPropietarioscrear(
                                   objPropietarios.causa_acto
                                    ,objPropietarios.propietario
                                    ,objPropietarios.titulo
                                    ,objPropietarios.notaria
                                    ,objPropietarios.fecha_escritura
                                    ,objPropietarios.fecha_registro
                                    ,objPropietarios.area
                                    ,objPropietarios.vendedor_anterior
                                     ,objFichaJuridica.id_ficha

                                    , objPropietarios.anotacion
                                        
                                    
                                );
                        }

                    }
                    objConsultarPredio = null;
                    
                    MessageBox.Show("Datos almacenados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiar();

                }
                else
                {
                    MessageBox.Show("Seleccione una ficha predial", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void lblFicha_Click(object sender, EventArgs e)
        {

        }

        private void txtFicha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPropietarios_Click(object sender, EventArgs e)
        {
            frmAgregarPropietarioscs fr = new frmAgregarPropietarioscs(this);
            fr.ShowDialog();

        }

        private void dgvPropietarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPropietariosFolios.SelectedRows.Count > 0)
            {
                spFichaPredialeHistoriaPropietariosconsultar_Result obj = (spFichaPredialeHistoriaPropietariosconsultar_Result)dgvPropietariosFolios.SelectedRows[0].DataBoundItem;
                List<spFichaPredialeHistoriaPropietariosconsultar_Result> lst = (List<spFichaPredialeHistoriaPropietariosconsultar_Result>)dgvPropietariosFolios.DataSource;
                lst.Remove(obj);
                dgvPropietariosFolios.DataSource = null;
                dgvPropietariosFolios.DataSource = lst;
            }
            else
            {
                MessageBox.Show("Seleccione un propietario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /*
        private void btnExportar_Click(object sender, EventArgs e)
        { Frase
                   }*/



         private void btnEditar_Click(object sender, EventArgs e)
         {
             if(dgvPropietariosFolios.SelectedRows.Count>0)
             {
                frmEditarPropietarios frmEditarPropietarios = new frmEditarPropietarios(this);
                frmEditarPropietarios.ShowDialog();

            }
         }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            frmExportar frm = new frmExportar(this);
            frm.Show();
        }
    }
}
    
