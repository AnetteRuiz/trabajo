﻿using System;
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
            SqlConnection conec = new SqlConnection("server=SWL040; database=Escuela; integrated security=true");
            conec.Open();

            return conec;
        }
    }
}
