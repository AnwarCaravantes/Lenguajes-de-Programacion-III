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
    public partial class CRUD_Producto : Form
    {
        public CRUD_Producto()
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
                    // Consulta con JOIN para mostrar el nombre del proveedor (R.nombre)
                    string query = "SELECT P.IdProducto, P.codigo, P.nombre AS 'Nombre Producto', P.precio, R.nombre AS 'Nombre Proveedor' " +
                                   "FROM PRODUCTOS P INNER JOIN PROVEEDORES R ON P.IdProveedor = R.IdProveedor";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de Productos: " + ex.Message, "Error de Consulta");
                }
            }
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProducto.Text)) return; // Usando txtIdProducto

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE PRODUCTOS SET codigo=@cod, nombre=@nom, precio=@pre, IdProveedor=@idprov WHERE IdProducto=@id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", txtIdProducto.Text);
                    cmd.Parameters.AddWithValue("@cod", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@pre", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@idprov", txtIdProveedor.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("El producto fue modificado exitosamente", "Modificación Exitosa");
                        MostrarDatos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar producto: " + ex.Message, "Error");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    // Incluye la clave foránea IdProveedor (txtIdProveedor)
                    string query = "INSERT INTO PRODUCTOS (codigo, nombre, precio, IdProveedor) VALUES (@cod, @nom, @pre, @idprov)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@cod", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@pre", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@idprov", txtIdProveedor.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El producto fue agregado exitosamente", "Alta Exitosa");
                    MostrarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar producto: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProducto.Text)) return; // Usando txtIdProducto

            if (MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM PRODUCTOS WHERE IdProducto=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", txtIdProducto.Text);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("El producto fue eliminado exitosamente", "Baja Exitosa");
                            MostrarDatos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar producto: " + ex.Message, "Error");
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
