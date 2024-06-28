namespace Escuela
{
    partial class boton_back_prin
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
            this.dtgrid_ID = new System.Windows.Forms.DataGridView();
            this.boton_backPrin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx_ID
            // 
            this.txtbx_ID.Location = new System.Drawing.Point(60, 55);
            this.txtbx_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_ID.Name = "txtbx_ID";
            this.txtbx_ID.Size = new System.Drawing.Size(132, 22);
            this.txtbx_ID.TabIndex = 0;
            // 
            // txtbx_Name
            // 
            this.txtbx_Name.Location = new System.Drawing.Point(60, 146);
            this.txtbx_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Name.Name = "txtbx_Name";
            this.txtbx_Name.Size = new System.Drawing.Size(203, 22);
            this.txtbx_Name.TabIndex = 1;
            // 
            // txtbx_Apell
            // 
            this.txtbx_Apell.Location = new System.Drawing.Point(343, 146);
            this.txtbx_Apell.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Apell.Name = "txtbx_Apell";
            this.txtbx_Apell.Size = new System.Drawing.Size(208, 22);
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
            this.cbbx_Grado.Location = new System.Drawing.Point(60, 241);
            this.cbbx_Grado.Margin = new System.Windows.Forms.Padding(4);
            this.cbbx_Grado.Name = "cbbx_Grado";
            this.cbbx_Grado.Size = new System.Drawing.Size(160, 24);
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
            this.cbbx_Curso.Location = new System.Drawing.Point(343, 241);
            this.cbbx_Curso.Margin = new System.Windows.Forms.Padding(4);
            this.cbbx_Curso.Name = "cbbx_Curso";
            this.cbbx_Curso.Size = new System.Drawing.Size(160, 24);
            this.cbbx_Curso.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
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
            this.groupBox1.Location = new System.Drawing.Point(233, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(579, 298);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // boton_NewAlum
            // 
            this.boton_NewAlum.Location = new System.Drawing.Point(852, 98);
            this.boton_NewAlum.Margin = new System.Windows.Forms.Padding(4);
            this.boton_NewAlum.Name = "boton_NewAlum";
            this.boton_NewAlum.Size = new System.Drawing.Size(100, 28);
            this.boton_NewAlum.TabIndex = 11;
            this.boton_NewAlum.Text = "Agregar";
            this.boton_NewAlum.UseVisualStyleBackColor = true;
            this.boton_NewAlum.Click += new System.EventHandler(this.boton_NewAlum_Click);
            // 
            // dtgrid_ID
            // 
            this.dtgrid_ID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_ID.Location = new System.Drawing.Point(233, 393);
            this.dtgrid_ID.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrid_ID.Name = "dtgrid_ID";
            this.dtgrid_ID.RowHeadersWidth = 51;
            this.dtgrid_ID.Size = new System.Drawing.Size(591, 160);
            this.dtgrid_ID.TabIndex = 12;
            // 
            // boton_backPrin
            // 
            this.boton_backPrin.Image = global::Escuela.Properties.Resources.regresar__1_;
            this.boton_backPrin.Location = new System.Drawing.Point(26, 13);
            this.boton_backPrin.Name = "boton_backPrin";
            this.boton_backPrin.Size = new System.Drawing.Size(60, 56);
            this.boton_backPrin.TabIndex = 13;
            this.boton_backPrin.UseVisualStyleBackColor = true;
            this.boton_backPrin.Click += new System.EventHandler(this.boton_backPrin_Click);
            // 
            // boton_back_prin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.boton_backPrin);
            this.Controls.Add(this.dtgrid_ID);
            this.Controls.Add(this.boton_NewAlum);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "boton_back_prin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_ID)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dtgrid_ID;
        private System.Windows.Forms.Button boton_backPrin;
    }
}