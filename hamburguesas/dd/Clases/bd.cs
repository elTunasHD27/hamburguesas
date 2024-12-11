using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dd.Clases
{
    public class bd
    {
        public static SqlConnection Obtenerconexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI; Persist Security Info=False;" +
                " Initial Catalog=dd; Data Source=Chey\\SQLEXPRESS02");
            conexion.Open();

            return conexion;

        }

    }
}
