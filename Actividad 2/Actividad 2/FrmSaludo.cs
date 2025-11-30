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
    public partial class FrmSaludo : Form
    {
        public FrmSaludo()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            // 1. Obtener el nombre del TextBox
            string nombreDelUsuario = txtNombre.Text;

            // 2. Construir el mensaje de saludo
            string mensajeSaludo = "Hola " + nombreDelUsuario + " ¿Qué tal va tu día?";

            // 3. Mostrar el mensaje en una ventana emergente
            MessageBox.Show(mensajeSaludo, "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // 1. Ocultar el formulario de saludo actual
            this.Hide();

            // 2. Crear y mostrar el formulario del menú principal
            FrmMenu menuFormulario = new FrmMenu();
            menuFormulario.Show();
        }
    }
}
