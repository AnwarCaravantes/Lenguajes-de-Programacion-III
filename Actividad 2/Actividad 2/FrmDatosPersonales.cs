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
    public partial class FrmDatosPersonales : Form
    {
        public FrmDatosPersonales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Ocultar el formulario de saludo actual
            this.Hide();

            // 2. Crear y mostrar el formulario del menú principal
            FrmMenu menuFormulario = new FrmMenu();
            menuFormulario.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
