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
    public partial class FrmSeleccionCRUD : Form
    {
        public FrmSeleccionCRUD()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Cliente fCliente = new CRUD_Cliente();
            fCliente.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Proveedor fProveedor = new CRUD_Proveedor();
            fProveedor.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Producto fProducto = new CRUD_Producto();
            fProducto.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal menu = new MenuPrincipal(); 
            menu.Show();
        }
    }
}
