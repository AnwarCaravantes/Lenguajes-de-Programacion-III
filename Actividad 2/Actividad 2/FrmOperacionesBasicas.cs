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
    public partial class FrmOperacionesBasicas : Form
    {
        public FrmOperacionesBasicas()
        {
            InitializeComponent();
        }

        private double ObtenerValor(TextBox textBox)
        {
            // Intenta convertir el texto a un número de punto flotante (double).
            // Si la conversión falla (ej. el campo está vacío o tiene texto no válido), devuelve 0.
            if (double.TryParse(textBox.Text, out double valor))
            {
                return valor;
            }
            return 0;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Suma los valores de los 6 TextBox
            double resultado = ObtenerValor(txtNum1) + ObtenerValor(txtNum2) + ObtenerValor(txtNum3) +
                               ObtenerValor(txtNum4) + ObtenerValor(txtNum5) + ObtenerValor(txtNum6);

            // Muestra el resultado en el TextBox de resultado
            txtResultado.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double num1 = ObtenerValor(txtNum1);
            double num2 = ObtenerValor(txtNum2);

            // Resta el 2º número del 1º
            double resultado = num1 - num2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            double num1 = ObtenerValor(txtNum1);
            double num2 = ObtenerValor(txtNum2);

            // Multiplica el 1º y el 2º número
            double resultado = num1 * num2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double num1 = ObtenerValor(txtNum1);
            double num2 = ObtenerValor(txtNum2);

            // Evitar la división por cero
            if (num2 != 0)
            {
                double resultado = num1 / num2;
                txtResultado.Text = resultado.ToString("N2"); // Muestra con 2 decimales para claridad
            }
            else
            {
                MessageBox.Show("Error: No se puede dividir por cero.", "Error de Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "Error";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia las 6 entradas
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
            txtNum4.Clear();
            txtNum5.Clear();
            txtNum6.Clear();

            // Limpia el campo de Resultado
            txtResultado.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menuFormulario = new FrmMenu();
            menuFormulario.Show();
        }
    }
}
