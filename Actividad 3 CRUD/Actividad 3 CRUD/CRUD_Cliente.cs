using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Actividad_3_CRUD
{
    public partial class CRUD_Cliente : Form
    {
        public CRUD_Cliente()
        {
            InitializeComponent();
        }


        private void MostrarDatos()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "SELECT IdCliente, dni, nombre, apellidos, fechaNac, tfno FROM CLIENTES";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de Clientes: " + ex.Message, "Error de Consulta");
                }
            }
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO CLIENTES (dni, nombre, apellidos, fechaNac, tfno) VALUES (@dni, @nom, @ape, @fec, @tel)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@dni", txtDni.Text);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ape", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@fec", dtpFechaNac.Value);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El usuario fue agregado exitosamente", "Alta Exitosa");
                    MostrarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar cliente: " + ex.Message);
                }
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCliente.Text)) return; 

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE CLIENTES SET dni=@dni, nombre=@nom, apellidos=@ape, fechaNac=@fec, tfno=@tel WHERE IdCliente=@id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", txtIdCliente.Text);
                    cmd.Parameters.AddWithValue("@dni", txtDni.Text);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ape", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@fec", dtpFechaNac.Value);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("El usuario fue modificado exitosamente", "Modificación Exitosa");
                        MostrarDatos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar cliente: " + ex.Message, "Error");
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCliente.Text)) return; 

            if (MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM CLIENTES WHERE IdCliente=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", txtIdCliente.Text);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("El usuario fue eliminado exitosamente", "Baja Exitosa");
                            MostrarDatos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar cliente: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmSeleccionCRUD selector = new FrmSeleccionCRUD();
            selector.Show();
        }
    }
}
