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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta el formulario del menú actual
            this.Hide();

            // Crea y muestra el formulario de Saludo
            FrmSaludo formularioSaludo = new FrmSaludo();
            formularioSaludo.Show();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta el formulario del menú actual
            this.Hide();

            // Crea y muestra el formulario de Datos Personales
            FrmDatosPersonales formularioDatos = new FrmDatosPersonales();
            formularioDatos.Show();
        }

        private void operacionesBasicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta el formulario del menú actual
            this.Hide();

            // Crea y muestra el formulario de Operaciones Básicas
            FrmOperacionesBasicas formularioOperaciones = new FrmOperacionesBasicas();
            formularioOperaciones.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación completa
            Application.Exit();
        }
    }
}
