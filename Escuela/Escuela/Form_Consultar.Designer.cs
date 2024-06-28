namespace Escuela
{
    partial class Form_Consultar
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
            this.dt_Consultar = new System.Windows.Forms.DataGridView();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.txtbx_buscarID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_backPrin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Consultar)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_Consultar
            // 
            this.dt_Consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Consultar.Location = new System.Drawing.Point(136, 164);
            this.dt_Consultar.Margin = new System.Windows.Forms.Padding(4);
            this.dt_Consultar.Name = "dt_Consultar";
            this.dt_Consultar.RowHeadersWidth = 51;
            this.dt_Consultar.Size = new System.Drawing.Size(796, 302);
            this.dt_Consultar.TabIndex = 0;
            this.dt_Consultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Consultar_CellContentClick);
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(429, 71);
            this.boton_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(100, 28);
            this.boton_buscar.TabIndex = 1;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // txtbx_buscarID
            // 
            this.txtbx_buscarID.Location = new System.Drawing.Point(237, 71);
            this.txtbx_buscarID.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_buscarID.Name = "txtbx_buscarID";
            this.txtbx_buscarID.Size = new System.Drawing.Size(132, 22);
            this.txtbx_buscarID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // boton_backPrin
            // 
            this.boton_backPrin.Image = global::Escuela.Properties.Resources.regresar__1_;
            this.boton_backPrin.Location = new System.Drawing.Point(31, 32);
            this.boton_backPrin.Name = "boton_backPrin";
            this.boton_backPrin.Size = new System.Drawing.Size(61, 61);
            this.boton_backPrin.TabIndex = 4;
            this.boton_backPrin.UseVisualStyleBackColor = true;
            this.boton_backPrin.Click += new System.EventHandler(this.boton_backPrin_Click);
            // 
            // Form_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.boton_backPrin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_buscarID);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.dt_Consultar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Consultar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Consultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_Consultar;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.TextBox txtbx_buscarID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_backPrin;
    }
}