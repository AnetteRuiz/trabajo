using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Escuela
{
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void boton_backPrin_Click(object sender, EventArgs e)
        {
            Form_Principal FP = new Form_Principal();
            FP.Show();
        }

        public void NewProf()
        {


            using (SqlConnection conec = BD.conexion())
            {

                string cmselec = "SELECT COUNT(*) FROM Profesores WHERE ID = @ID";

                SqlCommand cmdselec = new SqlCommand(cmselec, conec);
                cmdselec.Parameters.AddWithValue("@ID", txtbx_ID.Text);

                int count = (int)cmdselec.ExecuteScalar();

                if (count != 0)
                {
                    MessageBox.Show("Id existente", "System");


                }
                else

                {
                    string newprof = ("insert into Profesores (ID, Nombre, Apellido, Especialidad) values (" + txtbx_ID.Text + " , '" + txtbx_Name.Text + "' , '" + txtbx_Apellido.Text + "', '" + txtbx_Especialidad.Text + "')");
                    SqlCommand cminsert = new SqlCommand(newprof, conec);
                    cminsert.ExecuteNonQuery();
                    MessageBox.Show("Alta exitosa", "System");

                }

            }

        }

        public void CargaRegistros()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conec = BD.conexion())
            {
                string consulta = "SELECT * FROM Profesores ORDER BY ID DESC";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conec);
                adaptador.Fill(tabla);
                SqlCommand cmselec = new SqlCommand(consulta, conec);
                cmselec.ExecuteNonQuery();
                dt_Profesores.DataSource = tabla;




            }

        }

        public void Form_Admin_Load(object sender, EventArgs e)
        {

            CargaRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewProf();
            CargaRegistros();
        }
    }
}
