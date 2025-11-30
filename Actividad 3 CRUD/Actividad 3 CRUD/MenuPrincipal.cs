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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void mensajeDeBienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Bienvenido a la tienda en linea ZAPATERIA UMI, donde podra encontrar todo lo que usted necesita y si no lo encuentra se lo conseguimos. " +
        "\nSomos su mejor opcion hoy y siempre.");
        
        }

        private void quiénesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "¿Quiénes Somos?" +
        "\nSomos una empresa mexicana, que trata de apoyar al comercio mexicano, todos nuestros productos son 100% mexicanos, por que creemos en nosotros y por que sabemos que podemos.");

        }

        private void misiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Misión" +
        "\nNuestra mision es darnos a conocer a nivel nacional y lograr el objetivo de que todos los mexicanos utilicen productos mexicanos, que abramos los ojos y veamos que no por que el producto sea de otro pais, signifique que es mejor.");

        }

        private void visiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Vision" + 
        "\nNuestra vision es que una vez que nos encontremos a nivel nacional, buscaremos el mercado internacional y llevaremos el nombre de nusetro producto, de nuestro pais, a todo el mundo para que sepan de lo que somos capaces.");

        }

        private void bienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void damasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Damas fDamas = new Damas();
            fDamas.Show();
        }

        private void caballerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Caballeros fCaballeros = new Caballeros();
            fCaballeros.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Compras fCompras = new CRUD_Compras();
            fCompras.Show();
        }
    }
}
