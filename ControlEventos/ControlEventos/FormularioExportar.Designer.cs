namespace ControlEventos
{
    partial class FormularioExportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioExportar));
            this.BotonExplorar = new System.Windows.Forms.Button();
            this.CampoRuta = new System.Windows.Forms.TextBox();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.BotonExportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonExplorar
            // 
            this.BotonExplorar.Location = new System.Drawing.Point(581, 46);
            this.BotonExplorar.Name = "BotonExplorar";
            this.BotonExplorar.Size = new System.Drawing.Size(75, 32);
            this.BotonExplorar.TabIndex = 0;
            this.BotonExplorar.Text = "Explorar";
            this.BotonExplorar.UseVisualStyleBackColor = true;
            this.BotonExplorar.Click += new System.EventHandler(this.BotonExplorar_Click);
            // 
            // CampoRuta
            // 
            this.CampoRuta.Location = new System.Drawing.Point(12, 51);
            this.CampoRuta.Name = "CampoRuta";
            this.CampoRuta.Size = new System.Drawing.Size(528, 22);
            this.CampoRuta.TabIndex = 1;
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Location = new System.Drawing.Point(12, 9);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(479, 17);
            this.Etiqueta1.TabIndex = 3;
            this.Etiqueta1.Text = "Seleccione el directorio donde quiere almacenar el archivo de exportación:";
            // 
            // BotonExportar
            // 
            this.BotonExportar.Location = new System.Drawing.Point(662, 46);
            this.BotonExportar.Name = "BotonExportar";
            this.BotonExportar.Size = new System.Drawing.Size(75, 32);
            this.BotonExportar.TabIndex = 4;
            this.BotonExportar.Text = "Exportar";
            this.BotonExportar.UseVisualStyleBackColor = true;
            this.BotonExportar.Click += new System.EventHandler(this.BotonExportar_Click);
            // 
            // FormularioExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 90);
            this.Controls.Add(this.BotonExportar);
            this.Controls.Add(this.Etiqueta1);
            this.Controls.Add(this.CampoRuta);
            this.Controls.Add(this.BotonExplorar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioExportar";
            this.Text = "Exportar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonExplorar;
        private System.Windows.Forms.TextBox CampoRuta;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Button BotonExportar;
    }
}