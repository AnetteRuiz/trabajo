using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Form_Acceso : Form
    {
        public Form_Acceso()
        {
            InitializeComponent();
        }

        private void login()
        {
            SqlConnection conexion = new SqlConnection("server=SWL040 ; database=Escuela ; integrated security = true");
            conexion.Open();

            SqlCommand cmslc = new SqlCommand("Select Nom_user,Contraseña from Users where Nom_user= '" + txtbx_name.Text + "' and Contraseña= '" + txtbx_passw.Text + "'",conexion);
            using (SqlDataReader rdr = cmslc.ExecuteReader())
            {
                if (rdr.Read())
                {
                    rdr.Close();
                    Visible = false;
                    Form_Admin FA = new Form_Admin();
                    FA.Show();
                  
                  
                   
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "System");
                }
                
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
            
        }

       
    }
}
