using System;
using System.CodeDom;
using System.Collections;
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
    public partial class boton_back_prin : Form
    {
        public boton_back_prin()
        {
            InitializeComponent();
        }

        public void NewAlum()
        {


            using (SqlConnection conec = BD.conexion())
            {
                
                string cmselec = "SELECT COUNT(*) FROM Estudiantes WHERE ID = @ID";

                    SqlCommand cmdselec = new SqlCommand(cmselec, conec);               
                    cmdselec.Parameters.AddWithValue("@ID", txtbx_ID.Text);

                    int count = (int)cmdselec.ExecuteScalar();

                    if (count != 0)
                    {
                        MessageBox.Show("Id existente", "System");


                    }
                    else

                    {
                        string newalum = ("insert into Estudiantes (ID, Nombre, Apellido,Grado,Curso) values (" + txtbx_ID.Text + " , '" + txtbx_Name.Text + "' , '" + txtbx_Apell.Text + "', '" + cbbx_Grado.Text + "' , '" + cbbx_Curso.Text + "')");
                        SqlCommand cminsert = new SqlCommand(newalum, conec);
                        cminsert.ExecuteNonQuery();
                        MessageBox.Show("Alta exitosa", "System");

                    }
               
            }
                       
        }


        private void boton_NewAlum_Click(object sender, EventArgs e)
        {
            NewAlum();
            CargaRegistros();

        }

       

        public void Form_Admin_Load(object sender, EventArgs e)
        {
      
            CargaRegistros();
        }

        public void CargaRegistros()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conec = BD.conexion())
            {
                string consulta = "SELECT * FROM Estudiantes ORDER BY ID DESC";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conec);
                adaptador.Fill(tabla);
                SqlCommand cmselec = new SqlCommand(consulta, conec);
                cmselec.ExecuteNonQuery();
                dtgrid_ID.DataSource = tabla;

                


            }
                
        }

        private void boton_backPrin_Click(object sender, EventArgs e)
        {
            Form_Principal FP = new Form_Principal();
            FP.Show();
        }
    }
}
