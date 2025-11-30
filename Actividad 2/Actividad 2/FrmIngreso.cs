using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Define la contraseña correcta.
            string contrasenaCorrecta = "1234";

            // Captura la contraseña ingresada por el usuario
            string contrasenaIngresada = txtContrasena.Text;

            // 1. Validar la contraseña
            if (contrasenaIngresada == contrasenaCorrecta)
            {
                // 2. Si la contraseña es correcta: Cargamos y mostramos el formulario principal (FrmMenu)

                // Crea una instancia del formulario del menú y lo mostramos
                FrmMenu menuFormulario = new FrmMenu();
                menuFormulario.Show();

                // Ocultamos el formulario de ingreso actual
                this.Hide();
            }
            else
            {
                // 3. Si la contraseña es incorrecta: Muestra un mensaje de error
                MessageBox.Show("Contraseña incorrecta. Inténtelo de nuevo.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);

               
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }

        private void textContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
