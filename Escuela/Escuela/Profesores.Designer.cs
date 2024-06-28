namespace Escuela
{
    partial class Profesores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbx_ID = new System.Windows.Forms.TextBox();
            this.txtbx_Apellido = new System.Windows.Forms.TextBox();
            this.txtbx_Name = new System.Windows.Forms.TextBox();
            this.txtbx_Especialidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_Profesores = new System.Windows.Forms.DataGridView();
            this.boton_backPrin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Profesores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbx_Especialidad);
            this.groupBox1.Controls.Add(this.txtbx_Name);
            this.groupBox1.Controls.Add(this.txtbx_Apellido);
            this.groupBox1.Controls.Add(this.txtbx_ID);
            this.groupBox1.Location = new System.Drawing.Point(270, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtbx_ID
            // 
            this.txtbx_ID.Location = new System.Drawing.Point(54, 56);
            this.txtbx_ID.Name = "txtbx_ID";
            this.txtbx_ID.Size = new System.Drawing.Size(100, 22);
            this.txtbx_ID.TabIndex = 0;
            // 
            // txtbx_Apellido
            // 
            this.txtbx_Apellido.Location = new System.Drawing.Point(293, 123);
            this.txtbx_Apellido.Name = "txtbx_Apellido";
            this.txtbx_Apellido.Size = new System.Drawing.Size(158, 22);
            this.txtbx_Apellido.TabIndex = 1;
            // 
            // txtbx_Name
            // 
            this.txtbx_Name.Location = new System.Drawing.Point(293, 56);
            this.txtbx_Name.Name = "txtbx_Name";
            this.txtbx_Name.Size = new System.Drawing.Size(158, 22);
            this.txtbx_Name.TabIndex = 2;
            // 
            // txtbx_Especialidad
            // 
            this.txtbx_Especialidad.Location = new System.Drawing.Point(22, 146);
            this.txtbx_Especialidad.Name = "txtbx_Especialidad";
            this.txtbx_Especialidad.Size = new System.Drawing.Size(132, 22);
            this.txtbx_Especialidad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Especialidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            // 
            // dt_Profesores
            // 
            this.dt_Profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Profesores.Location = new System.Drawing.Point(69, 242);
            this.dt_Profesores.Name = "dt_Profesores";
            this.dt_Profesores.RowHeadersWidth = 51;
            this.dt_Profesores.RowTemplate.Height = 24;
            this.dt_Profesores.Size = new System.Drawing.Size(679, 204);
            this.dt_Profesores.TabIndex = 1;
            // 
            // boton_backPrin
            // 
            this.boton_backPrin.Image = global::Escuela.Properties.Resources.regresar__1_;
            this.boton_backPrin.Location = new System.Drawing.Point(12, 12);
            this.boton_backPrin.Name = "boton_backPrin";
            this.boton_backPrin.Size = new System.Drawing.Size(63, 58);
            this.boton_backPrin.TabIndex = 2;
            this.boton_backPrin.UseVisualStyleBackColor = true;
            this.boton_backPrin.Click += new System.EventHandler(this.boton_backPrin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton_backPrin);
            this.Controls.Add(this.dt_Profesores);
            this.Controls.Add(this.groupBox1);
            this.Name = "Profesores";
            this.Text = "Profesores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Profesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_Especialidad;
        private System.Windows.Forms.TextBox txtbx_Name;
        private System.Windows.Forms.TextBox txtbx_Apellido;
        private System.Windows.Forms.TextBox txtbx_ID;
        private System.Windows.Forms.DataGridView dt_Profesores;
        private System.Windows.Forms.Button boton_backPrin;
        private System.Windows.Forms.Button button1;
    }
}