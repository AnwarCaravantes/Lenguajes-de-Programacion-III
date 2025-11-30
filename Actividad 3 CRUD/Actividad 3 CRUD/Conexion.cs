using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; // Agregamos la librería para usar SQL
using System.Windows.Forms; // Se agrega para usar MessageBox.Show en caso de error

namespace Actividad_3_CRUD
{
    public static class Conexion // Esta era una conexion interna, la cambiamos a publica y estatica para que funcione para todos los formularios sin crear objetos
    {
        // Aqui se hace la cadena de conexion con el nombre de nuestro servidor y el nombre de la base de datos
        public static string Cadena = "Data Source=DESKTOP-RRPJMIP\\SQLEXPRESS;Initial Catalog=ZapateriaUMI;Integrated Security=True";

        // Función que devuelve un objeto SqlConnection usando la cadena de conexión
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(Cadena);
        }
    }
}
