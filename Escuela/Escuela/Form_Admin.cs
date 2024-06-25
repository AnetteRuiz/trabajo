using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        
        public void NewAlum()
        {
            SqlConnection conexion = new SqlConnection("server=SWL040 ; database=Escuela ; integrated security = true");
            conexion.Open();

            SqlCommand cmslc = new SqlCommand("Select ID from Estudiantes where ID= '" + txtbx_ID.Text + "'", conexion);
            SqlDataReader rdr = cmslc.ExecuteReader();
       
            if (rdr.Read())
            {
                MessageBox.Show("Id existente", "System");
              
            }
            else 
            {
                string newalum = ("insert into Estudiantes (ID, Nombre, Apellido,Grado,Curso) values (" + txtbx_ID.Text + " , '" + txtbx_Name.Text + "' , '" + txtbx_Apell.Text + "', '" + cbbx_Grado.Text + "' , '" + cbbx_Curso.Text + "' )");
                SqlCommand cmin = new SqlCommand(newalum, conexion);
                cmin.ExecuteNonQuery();
                MessageBox.Show("Alta exitosa", "System");
            }

           
            
        }

        private void boton_NewAlum_Click(object sender, EventArgs e)
        {
            NewAlum();

        }
    }
}
