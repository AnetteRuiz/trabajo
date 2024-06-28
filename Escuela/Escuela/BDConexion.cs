using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Escuela
{
    internal class BDConexion
    {
        public static SqlConnection conec()
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-OCCNR6MH ; database=Escuela ; integrated security = true");
            conexion.Open();

            return conexion;
        }
    }
}
