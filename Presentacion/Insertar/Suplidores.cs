using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidade;

namespace Presentacion.Insertar
{
    public partial class Suplidores : Form
    {
        public Suplidores()
        {
            InitializeComponent();
        }

        private Esuplidores suplidor;
        private static Acceso_Suplidores acceso_suplidores = new Acceso_Suplidores();
        private void Guardar()
        {
            try
            {
                if (suplidor == null) suplidor = new Esuplidores();

                suplidor.nombre = txtNombre.Text;
                suplidor.direccion = txtDireccion.Text;
                suplidor.ciudad = txtCiudad.Text;
                suplidor.telefono = txtTel.Text;

                acceso_suplidores.InsertarSuplidor(suplidor);

                if (acceso_suplidores.stringBuilder.Length != 0)
                {
                    MessageBox.Show(acceso_suplidores.stringBuilder.ToString(), "Para continuar:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("CLIENTE REGISTRADO CORRECTAMENTE", "CLIENTE REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
