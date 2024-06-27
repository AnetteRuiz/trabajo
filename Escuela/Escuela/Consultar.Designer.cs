namespace Escuela
{
    partial class Consultar
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
            ((System.ComponentModel.ISupportInitialize)(this.dt_Consultar)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_Consultar
            // 
            this.dt_Consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Consultar.Location = new System.Drawing.Point(102, 133);
            this.dt_Consultar.Name = "dt_Consultar";
            this.dt_Consultar.Size = new System.Drawing.Size(597, 222);
            this.dt_Consultar.TabIndex = 0;
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(322, 58);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(75, 23);
            this.boton_buscar.TabIndex = 1;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // txtbx_buscarID
            // 
            this.txtbx_buscarID.Location = new System.Drawing.Point(178, 58);
            this.txtbx_buscarID.Name = "txtbx_buscarID";
            this.txtbx_buscarID.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscarID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_buscarID);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.dt_Consultar);
            this.Name = "Consultar";
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
    }
}