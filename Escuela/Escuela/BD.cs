using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    public class BD
    {
        public static SqlConnection conexion()
        {
            SqlConnection conec = new SqlConnection("server=LAPTOP-OCCNR6MH; database=Escuela; integrated security=true");
            conec.Open();

            return conec;
        }
    }
}
