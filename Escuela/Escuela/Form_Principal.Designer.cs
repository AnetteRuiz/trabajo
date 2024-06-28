namespace Escuela
{
    partial class Form_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.boton_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_alumno = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_profesor = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boton_salir,
            this.boton_nuevo,
            this.boton_consultar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // boton_salir
            // 
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(52, 24);
            this.boton_salir.Text = "Salir";
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // boton_nuevo
            // 
            this.boton_nuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boton_alumno,
            this.boton_profesor});
            this.boton_nuevo.Name = "boton_nuevo";
            this.boton_nuevo.Size = new System.Drawing.Size(66, 24);
            this.boton_nuevo.Text = "Nuevo";
            // 
            // boton_alumno
            // 
            this.boton_alumno.Name = "boton_alumno";
            this.boton_alumno.Size = new System.Drawing.Size(224, 26);
            this.boton_alumno.Text = "Alumno";
            this.boton_alumno.Click += new System.EventHandler(this.boton_alumno_Click);
            // 
            // boton_profesor
            // 
            this.boton_profesor.Name = "boton_profesor";
            this.boton_profesor.Size = new System.Drawing.Size(224, 26);
            this.boton_profesor.Text = "Profesor";
            // 
            // boton_consultar
            // 
            this.boton_consultar.Name = "boton_consultar";
            this.boton_consultar.Size = new System.Drawing.Size(85, 24);
            this.boton_consultar.Text = "Consultar";
            this.boton_consultar.Click += new System.EventHandler(this.boton_consultar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Escuela.Properties.Resources.uag__1___2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 336);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem boton_salir;
        private System.Windows.Forms.ToolStripMenuItem boton_nuevo;
        private System.Windows.Forms.ToolStripMenuItem boton_alumno;
        private System.Windows.Forms.ToolStripMenuItem boton_profesor;
        private System.Windows.Forms.ToolStripMenuItem boton_consultar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}