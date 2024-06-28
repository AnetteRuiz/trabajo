using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            Form_Acceso FA = new Form_Acceso();
            FA.Show();   
           
        }

        private void boton_alumno_Click(object sender, EventArgs e)
        {
            boton_back_prin FADMIN = new boton_back_prin();
            FADMIN.Show();
        }

        private void boton_consultar_Click(object sender, EventArgs e)
        {
            Form_Consultar FCON = new Form_Consultar();   
            FCON.Show();
        }
    }
}
