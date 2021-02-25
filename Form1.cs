using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Fecha: 24 de Febrero 2021
/// Autor: Mauricio Gomez Restrepo 
/// Funcionalidad: Ejercicio de Casa de cambios 
/// </summary>
namespace wCasaDeCambios
{

    
    public partial class frmCasaCambio : Form
    {
        
        public frmCasaCambio()
        {
            InitializeComponent();
            InicializarFormulario();

        }

        private void InicializarFormulario()
        {

            try
            {
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtValor.Text = "";
                txtCantidadValorCambio.Text = "";

                #region [Llenar combo ciudad ]
                cmbCiuda.Items.Clear();
                cmbCiuda.Items.Add("Medellin");
                cmbCiuda.Items.Add("Madrid");
                cmbCiuda.Items.Add("New York");
                #endregion

                #region [ Llenar combo moneda origen ]
                cmbMonedaOrigen.Items.Clear();
                cmbMonedaOrigen.Items.Add("Pesos");
                cmbMonedaOrigen.Items.Add("Euros");
                cmbMonedaOrigen.Items.Add("Dolar");
                #endregion

                #region [Llenar combo moneda destino ]
                cmbMonedaDestino.Items.Clear();
                cmbMonedaDestino.Items.Add("Pesos");
                cmbMonedaDestino.Items.Add("Euros");
                cmbMonedaDestino.Items.Add("Dolar");
                #endregion

                rdoEfectivo.Checked = true;


            }
            catch (Exception Err)
            {

                MessageBox.Show(Err.Message);
            }

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {

            double valor = 0;
            double CantidadValorCambiar = double.Parse(txtCantidadValorCambio.Text);
            double ValorCanje = double.Parse(txtValor.Text);
            string usuario;
            usuario = " Nombre:  "  + txtNombre.Text + "\n" + " Apellido:  " +  txtApellido.Text + "\n" 
                + " Direccion:  " + txtDireccion.Text + "\n" + " Telefono:  " +
                txtTelefono.Text + "\n" + " Ciudad:  " + cmbCiuda.Text + "\n" ;
            usuario = usuario + " El valor a pagar es:  "  ;


            if (cmbMonedaOrigen.Text == cmbMonedaDestino.Text)
            {
                MessageBox.Show(" Verifique que los tipos de monedas sean  diferentes ");

            }
            else
            {
                  // Calcular las converciones
                switch (cmbMonedaDestino.Text)
                {
                    case "Pesos":
                        valor = CantidadValorCambiar * ValorCanje; usuario = usuario + valor + " Pesos colombianos " ;
                        break;

                    case "Euros":
                        valor = CantidadValorCambiar / ValorCanje; usuario = usuario + valor + " Euros ";
                        break;

                    case "Dolar":
                        valor = CantidadValorCambiar / ValorCanje; usuario = usuario + valor + " Dolares ";
                        break;

                    default:; break;

                }
                MessageBox.Show(usuario);
            }    

        }

        private void frmCasaCambio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }

        private void smnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
