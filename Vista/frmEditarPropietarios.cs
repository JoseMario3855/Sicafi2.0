using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.EstudioJuridico;

namespace Vista
{
    public partial class frmEditarPropietarios : Form
    {
        frmFichaPredial objfrmFichaPredia;

        public frmEditarPropietarios(frmFichaPredial objfrmFichaPredial)
        {
            InitializeComponent();
            this.objfrmFichaPredia = objfrmFichaPredial;
        }

        private void frmEditarPropietarios_Load(object sender, EventArgs e)
        {
            spFichaPredialeHistoriaPropietariosconsultar_Result objspFichaPredialeHistoriaPropietarios= (spFichaPredialeHistoriaPropietariosconsultar_Result) objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].DataBoundItem;
            txtCausaActo.Text = objspFichaPredialeHistoriaPropietarios.causa_acto;
            txtPropietario.Text = objspFichaPredialeHistoriaPropietarios.propietario;
            txtEscritura.Text = objspFichaPredialeHistoriaPropietarios.titulo;
            txtNotaria.Text = objspFichaPredialeHistoriaPropietarios.notaria;
            dtpFechaEscritura.Value = objspFichaPredialeHistoriaPropietarios.fecha_escritura;
            dtpFechaRegistro.Value = objspFichaPredialeHistoriaPropietarios.fecha_registro;
            txtArea.Text = objspFichaPredialeHistoriaPropietarios.area.ToString();
            txtVendedor.Text = objspFichaPredialeHistoriaPropietarios.vendedor_anterior;
            txtAnotacion.Text = objspFichaPredialeHistoriaPropietarios.anotacion;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            spFichaPredialeHistoriaPropietariosconsultar_Result objspFichaPredialeHistoriaPropietarios = (spFichaPredialeHistoriaPropietariosconsultar_Result)objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].DataBoundItem;
            objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].Cells["CausaActoPopietarios"].Value = txtCausaActo.Text;
            objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].Cells["Propietario"].Value = txtPropietario.Text;
            objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].Cells["TItulo"].Value = txtEscritura.Text;
            objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].Cells["Notaria"].Value = txtNotaria.Text;
            objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].Cells["FechaEscritura"].Value = dtpFechaEscritura.Value;
            objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].Cells["FechaRegistro"].Value = dtpFechaRegistro.Value;
            objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].Cells["Area"].Value = Convert.ToDecimal(txtArea.Text);
            objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].Cells["VendedorAnterior"].Value = txtVendedor.Text;
            objfrmFichaPredia.dgvPropietariosFolios.SelectedRows[0].Cells["Anotacion"].Value = txtAnotacion.Text;

            objfrmFichaPredia.dgvPropietariosFolios.Refresh();
            this.Close();
        }
    }
}
