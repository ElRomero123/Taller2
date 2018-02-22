namespace ControlEventos
{
    partial class FormularioImportar
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
            this.CampoRuta = new System.Windows.Forms.TextBox();
            this.BotonExplorar = new System.Windows.Forms.Button();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.BotonImportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CampoRuta
            // 
            this.CampoRuta.Location = new System.Drawing.Point(12, 73);
            this.CampoRuta.Name = "CampoRuta";
            this.CampoRuta.Size = new System.Drawing.Size(414, 22);
            this.CampoRuta.TabIndex = 0;
            // 
            // BotonExplorar
            // 
            this.BotonExplorar.Location = new System.Drawing.Point(432, 61);
            this.BotonExplorar.Name = "BotonExplorar";
            this.BotonExplorar.Size = new System.Drawing.Size(75, 34);
            this.BotonExplorar.TabIndex = 1;
            this.BotonExplorar.Text = "Explorar";
            this.BotonExplorar.UseVisualStyleBackColor = true;
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Location = new System.Drawing.Point(9, 9);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(175, 17);
            this.Etiqueta1.TabIndex = 2;
            this.Etiqueta1.Text = "Ruta de origen del archivo";
            // 
            // BotonImportar
            // 
            this.BotonImportar.Location = new System.Drawing.Point(513, 61);
            this.BotonImportar.Name = "BotonImportar";
            this.BotonImportar.Size = new System.Drawing.Size(75, 34);
            this.BotonImportar.TabIndex = 3;
            this.BotonImportar.Text = "Importar";
            this.BotonImportar.UseVisualStyleBackColor = true;
            this.BotonImportar.Click += new System.EventHandler(this.BotonImportar_Click);
            // 
            // FormularioImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 107);
            this.Controls.Add(this.BotonImportar);
            this.Controls.Add(this.Etiqueta1);
            this.Controls.Add(this.BotonExplorar);
            this.Controls.Add(this.CampoRuta);
            this.Name = "FormularioImportar";
            this.Text = "FormularioImportar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CampoRuta;
        private System.Windows.Forms.Button BotonExplorar;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Button BotonImportar;
    }
}