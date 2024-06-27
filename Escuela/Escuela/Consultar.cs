using System;
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
    public partial class Consultar : Form
    {
        private DataTable dataTable;
        public Consultar()
        {
            InitializeComponent();
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
           FiltraRegistro();
          
        }

        public void BuscaRegistro()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conec = BD.conexion())
            {
                string consulta = "SELECT * FROM Estudiantes";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conec);
                adaptador.Fill(tabla);
                SqlCommand cmselec = new SqlCommand(consulta, conec);
                cmselec.ExecuteNonQuery();
                dt_Consultar.DataSource = tabla;

            }

        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            //BuscaRegistro();
        }

        public void FiltraRegistro()
        {

            DataTable dt = new DataTable();
            using (SqlConnection conec = BD.conexion())
            {
                //string consul = "SELECT * FROM Estudiantes WHERE ID = @ID";
                string consul = "SELECT dbo.Estudiantes.ID, dbo.Estudiantes.Nombre, dbo.Estudiantes.Apellido, dbo.Estudiantes.Curso, dbo.Estudiantes.Grado, dbo.Inscripciones.FechaInscripcion, dbo.Profesores.Nombre AS Profesor, dbo.Profesores.Apellido AS [P Apellido], dbo.Profesores.Especialidad, dbo.Cursos.Nombre AS Materia FROM dbo.Profesores LEFT OUTER JOIN dbo.Estudiantes RIGHT OUTER JOIN dbo.Inscripciones ON dbo.Estudiantes.ID = dbo.Inscripciones.ID_Estudiante RIGHT OUTER JOIN dbo.Cursos ON dbo.Inscripciones.ID_Curso = dbo.Cursos.ID ON dbo.Profesores.ID = dbo.Cursos.ID_Profesor WHERE (dbo.Estudiantes.ID = @ID OR dbo.Estudiantes.ID IS NULL)";
                SqlCommand ver = new SqlCommand(consul, conec);
                ver.Parameters.AddWithValue("@ID", txtbx_buscarID.Text);
                
                using (SqlDataReader adaptador = ver.ExecuteReader())
                {
                    if (adaptador.HasRows)
                    {
                        // Limpiar el DataTable si tiene datos anteriores
                        dt.Clear();

                        // Llenar el DataTable con los resultados de la consulta
                        dt.Load(adaptador);
                        dt_Consultar.DataSource = dt;
                    }
                    else
                    {
                        dt.Clear();
                        dt_Consultar.DataSource = dt;
                        MessageBox.Show("No se encontró el registro");
                    }
                }

            }

        }


    }
}
