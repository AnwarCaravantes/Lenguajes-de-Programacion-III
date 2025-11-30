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
    public partial class CRUD_Compras : Form
    {
        public CRUD_Compras()
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

                    string query = "SELECT " +
                                   "C.IdCompra, C.FechaCompra, " +
                                   "C.IdCliente, CL.dni AS 'DNI Cliente', " +  
                                   "C.IdProducto, P.codigo AS 'Código Producto' " + 
                                   "FROM COMPRAS C " +

                                   "INNER JOIN CLIENTES CL ON C.IdCliente = CL.IdCliente " +
                                   "INNER JOIN PRODUCTOS P ON C.IdProducto = P.IdProducto";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de Compras: " + ex.Message, "Error de Consulta");
                }
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    
                    string query = "INSERT INTO COMPRAS (IdCliente, IdProducto) VALUES (@idcli, @idprod)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    
                    cmd.Parameters.AddWithValue("@idcli", txtIdCliente.Text);
                    cmd.Parameters.AddWithValue("@idprod", txtIdProducto.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La compra fue registrada exitosamente", "Alta Exitosa");
                    MostrarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la compra: " + ex.Message, "Error de Compra");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCliente.Text) || string.IsNullOrEmpty(txtIdProducto.Text))
            {
                MessageBox.Show("Debe ingresar el DNI del cliente y el Código del producto para eliminar la compra.", "Advertencia");
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta compra específica?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    try
                    {
                        con.Open();                        
                        string query = "DELETE FROM COMPRAS WHERE IdCliente=@idcli AND IdProducto=@idprod";
                        SqlCommand cmd = new SqlCommand(query, con);
                        
                        cmd.Parameters.AddWithValue("@idcli", txtIdCliente.Text);
                        cmd.Parameters.AddWithValue("@idprod", txtIdProducto.Text);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("La compra fue eliminada exitosamente", "Baja Exitosa");
                            MostrarDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró esa compra específica.", "Aviso");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar compra: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
           
            this.Close();

            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }
    }
}
