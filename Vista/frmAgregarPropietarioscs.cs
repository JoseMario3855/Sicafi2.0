using Datos.EstudioJuridico;
using Datos.Sicafi.Listas;
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
    public partial class frmAgregarPropietarioscs : Form
    {
        frmFichaPredial objfrmFichaPredial;
        public object dgvPropietariosFolios;

        public frmAgregarPropietarioscs(frmFichaPredial objfrmFichaPredial)
        {
            InitializeComponent();
            this.objfrmFichaPredial = objfrmFichaPredial;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtPropietarios.Text))
            {
                MessageBox.Show("ingrese el propietario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtCausaActo.Text))
            {
                MessageBox.Show("ingrese la causa del acto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtArea.Text))
            {
                MessageBox.Show("ingrese el area del folio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(TxtNotaria.Text))
            {
                MessageBox.Show("ingrese la notaria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtVendedor.Text))
            {
                MessageBox.Show("ingrese el vendedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtAnotacion.Text))
            {
                MessageBox.Show("ingrese la anotacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                spFichaPredialeHistoriaPropietariosconsultar_Result objPropietarios = new spFichaPredialeHistoriaPropietariosconsultar_Result();
                objPropietarios.propietario = txtPropietarios.Text;
                objPropietarios.causa_acto = txtCausaActo.Text;
                objPropietarios.notaria = TxtNotaria.Text;
                objPropietarios.titulo = txtTitulo.Text;
                objPropietarios.area = Convert.ToDecimal(txtArea.Text);
                objPropietarios.vendedor_anterior = txtVendedor.Text;
                objPropietarios.fecha_escritura =dtpFechaEscritura.Value;
                objPropietarios.fecha_registro =dtpFechaRegistro.Value;
                objPropietarios.anotacion = txtAnotacion.Text;
                List<spFichaPredialeHistoriaPropietariosconsultar_Result> lst;
                if(objfrmFichaPredial.dgvPropietariosFolios.DataSource==null)
                {
                    lst = new List<spFichaPredialeHistoriaPropietariosconsultar_Result>();
                    lst.Add(objPropietarios);
                }
                else
                {
                    lst = (List<spFichaPredialeHistoriaPropietariosconsultar_Result>)objfrmFichaPredial.dgvPropietariosFolios.DataSource;
                    lst.Add(objPropietarios);

                }
                objfrmFichaPredial.dgvPropietariosFolios.DataSource = null;
                objfrmFichaPredial.dgvPropietariosFolios.DataSource = lst;
                 void limpiar()
                {
                    txtPropietarios.Text = string.Empty;
                    txtVendedor.Text = string.Empty;

                }  
                DialogResult result = MessageBox.Show("Desea agregar  otro propietario para esta anotación", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch(result)
                {
                    case DialogResult.Yes:
                        lst = lst;
                        limpiar();
                        break;
                    case DialogResult.No:
                        Close();
                        
                        break;

                }
               
               
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
