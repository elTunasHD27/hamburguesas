using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dd.Clases
{
    public class ventaDAL
    {
        public static int AgregarProducto(producto producto)
        {
            int retorna = 0;

            using (SqlConnection conexion = bd.Obtenerconexion())
            {
                string query = "insert into productoss (nombre,cantidad,precio) values('"+producto.nombre+
                    "',"+producto.cantidad+","+producto.precio+")";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<producto> presentarregistro()
        {
            List<producto> Lista = new List<producto>();
            using (SqlConnection conexion = bd.Obtenerconexion())
            {
                string query = "select * from productoss";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    producto producto = new producto();
                    producto.id = reader.GetInt32(0);
                    producto.nombre = reader.GetString(1);
                    producto.cantidad = reader.GetInt32(2);
                    producto.precio = reader.GetInt32(3);
                    Lista.Add(producto);
                }
                conexion.Close();
                return Lista;
            
            }
        }
        public static int Modificarventa(producto producto)
        {
            int result = 0;
            using (SqlConnection conexion = bd.Obtenerconexion())
            {
                string query = "update productoss set nombre='"+producto.nombre+"', cantidad= "+producto.cantidad+"" +
                    ", precio= "+producto.precio+" where id= "+producto.id+"    ";
                SqlCommand comando = new SqlCommand(query, conexion);

                result=comando.ExecuteNonQuery();
                conexion.Close();

            }
            return result;

        }
    }
}
