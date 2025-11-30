using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3_CRUD
{
    public partial class CRUD_Proveedor : Form
    {
        public CRUD_Proveedor()
        {
            InitializeComponent();
        }

        // Función para Consultar y Cargar datos en el DataGridView (dgvDatos)
        private void MostrarDatos()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "SELECT IdProveedor, nif, nombre, direccion FROM PROVEEDORES";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de Proveedores: " + ex.Message, "Error de Consulta");
                }
            }
        }





        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProveedor.Text)) return; // Usando txtIdProveedor

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE PROVEEDORES SET nif=@nif, nombre=@nom, direccion=@dir WHERE IdProveedor=@id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", txtIdProveedor.Text);
                    cmd.Parameters.AddWithValue("@nif", txtNif.Text);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@dir", txtDireccion.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("El proveedor fue modificado exitosamente", "Modificación Exitosa");
                        MostrarDatos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar proveedor: " + ex.Message, "Error");
                }
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO PROVEEDORES (nif, nombre, direccion) VALUES (@nif, @nom, @dir)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@nif", txtNif.Text);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@dir", txtDireccion.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El proveedor fue agregado exitosamente", "Alta Exitosa");
                    MostrarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar proveedor: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProveedor.Text)) return; // Usando txtIdProveedor

            if (MessageBox.Show("¿Está seguro de eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM PROVEEDORES WHERE IdProveedor=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", txtIdProveedor.Text);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("El proveedor fue eliminado exitosamente", "Baja Exitosa");
                            MostrarDatos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar proveedor: " + ex.Message, "Error");
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
