namespace Escuela
{
    partial class Form_Admin
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
            this.txtbx_ID = new System.Windows.Forms.TextBox();
            this.txtbx_Name = new System.Windows.Forms.TextBox();
            this.txtbx_Apell = new System.Windows.Forms.TextBox();
            this.cbbx_Grado = new System.Windows.Forms.ComboBox();
            this.cbbx_Curso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boton_NewAlum = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_ID
            // 
            this.txtbx_ID.Location = new System.Drawing.Point(45, 45);
            this.txtbx_ID.Name = "txtbx_ID";
            this.txtbx_ID.Size = new System.Drawing.Size(100, 20);
            this.txtbx_ID.TabIndex = 0;
            // 
            // txtbx_Name
            // 
            this.txtbx_Name.Location = new System.Drawing.Point(45, 119);
            this.txtbx_Name.Name = "txtbx_Name";
            this.txtbx_Name.Size = new System.Drawing.Size(153, 20);
            this.txtbx_Name.TabIndex = 1;
            // 
            // txtbx_Apell
            // 
            this.txtbx_Apell.Location = new System.Drawing.Point(257, 119);
            this.txtbx_Apell.Name = "txtbx_Apell";
            this.txtbx_Apell.Size = new System.Drawing.Size(157, 20);
            this.txtbx_Apell.TabIndex = 2;
            // 
            // cbbx_Grado
            // 
            this.cbbx_Grado.FormattingEnabled = true;
            this.cbbx_Grado.Items.AddRange(new object[] {
            "1ro semestre",
            "2do semestre",
            "3ro semestre",
            "4to semestre",
            "5to semestre",
            "6to semestre",
            "8vo semestre"});
            this.cbbx_Grado.Location = new System.Drawing.Point(45, 196);
            this.cbbx_Grado.Name = "cbbx_Grado";
            this.cbbx_Grado.Size = new System.Drawing.Size(121, 21);
            this.cbbx_Grado.TabIndex = 3;
            // 
            // cbbx_Curso
            // 
            this.cbbx_Curso.FormattingEnabled = true;
            this.cbbx_Curso.Items.AddRange(new object[] {
            "Ing. Software",
            "Ing. Biomédica",
            "Lic. Derecho",
            "Lic. Administración"});
            this.cbbx_Curso.Location = new System.Drawing.Point(257, 196);
            this.cbbx_Curso.Name = "cbbx_Curso";
            this.cbbx_Curso.Size = new System.Drawing.Size(121, 21);
            this.cbbx_Curso.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbx_Curso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbx_Grado);
            this.groupBox1.Controls.Add(this.txtbx_ID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbx_Name);
            this.groupBox1.Controls.Add(this.txtbx_Apell);
            this.groupBox1.Location = new System.Drawing.Point(175, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 242);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // boton_NewAlum
            // 
            this.boton_NewAlum.Location = new System.Drawing.Point(639, 80);
            this.boton_NewAlum.Name = "boton_NewAlum";
            this.boton_NewAlum.Size = new System.Drawing.Size(75, 23);
            this.boton_NewAlum.TabIndex = 11;
            this.boton_NewAlum.Text = "Agregar";
            this.boton_NewAlum.UseVisualStyleBackColor = true;
            this.boton_NewAlum.Click += new System.EventHandler(this.boton_NewAlum_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 130);
            this.dataGridView1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.newToolStripMenuItem.Text = "Nuevo";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boton_NewAlum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Admin";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_ID;
        private System.Windows.Forms.TextBox txtbx_Name;
        private System.Windows.Forms.TextBox txtbx_Apell;
        private System.Windows.Forms.ComboBox cbbx_Grado;
        private System.Windows.Forms.ComboBox cbbx_Curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button boton_NewAlum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
    }
}