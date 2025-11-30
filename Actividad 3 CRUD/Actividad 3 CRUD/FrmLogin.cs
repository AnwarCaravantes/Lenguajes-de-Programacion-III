using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3_CRUD
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Establecemos la Contraseña
            string contraseñaCorrecta = "admin123";

            if (txtPassword.Text == contraseñaCorrecta)
            {
                MessageBox.Show("Acceso concedido");

                this.Close();

                // Oculta el Login y abre el formulario de Clientes (el primer CRUD)
                this.Hide();
                FrmSeleccionCRUD selector = new FrmSeleccionCRUD();
                selector.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
