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
            using (SqlConnection conec = BD.conexion())
            {

                SqlCommand cmslc = new SqlCommand("Select Nom_user,Contraseña from Users where Nom_user= '" + txtbx_name.Text + "' and Contraseña= '" + txtbx_passw.Text + "'", conec);
                SqlDataReader rdr = cmslc.ExecuteReader();
                
                    if (rdr.Read())
                    {
                        rdr.Close();
                        Visible = false;
                        boton_back_prin FA = new boton_back_prin();
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
