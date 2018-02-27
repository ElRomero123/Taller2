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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioImportar));
            this.CampoRuta = new System.Windows.Forms.TextBox();
            this.BotonExplorar = new System.Windows.Forms.Button();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.BotonImportar = new System.Windows.Forms.Button();
            this.EtiquetaEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CampoRuta
            // 
            this.CampoRuta.Location = new System.Drawing.Point(12, 35);
            this.CampoRuta.Name = "CampoRuta";
            this.CampoRuta.Size = new System.Drawing.Size(414, 22);
            this.CampoRuta.TabIndex = 0;
            // 
            // BotonExplorar
            // 
            this.BotonExplorar.Location = new System.Drawing.Point(461, 29);
            this.BotonExplorar.Name = "BotonExplorar";
            this.BotonExplorar.Size = new System.Drawing.Size(75, 34);
            this.BotonExplorar.TabIndex = 1;
            this.BotonExplorar.Text = "Explorar";
            this.BotonExplorar.UseVisualStyleBackColor = true;
            this.BotonExplorar.Click += new System.EventHandler(this.BotonExplorar_Click);
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Location = new System.Drawing.Point(9, 9);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(210, 17);
            this.Etiqueta1.TabIndex = 2;
            this.Etiqueta1.Text = "Seleccione el archivo de origen:";
            // 
            // BotonImportar
            // 
            this.BotonImportar.Location = new System.Drawing.Point(542, 29);
            this.BotonImportar.Name = "BotonImportar";
            this.BotonImportar.Size = new System.Drawing.Size(75, 34);
            this.BotonImportar.TabIndex = 3;
            this.BotonImportar.Text = "Importar";
            this.BotonImportar.UseVisualStyleBackColor = true;
            this.BotonImportar.Click += new System.EventHandler(this.BotonImportar_Click);
            // 
            // EtiquetaEstado
            // 
            this.EtiquetaEstado.AutoSize = true;
            this.EtiquetaEstado.Location = new System.Drawing.Point(12, 80);
            this.EtiquetaEstado.Name = "EtiquetaEstado";
            this.EtiquetaEstado.Size = new System.Drawing.Size(20, 17);
            this.EtiquetaEstado.TabIndex = 4;
            this.EtiquetaEstado.Text = "...";
            // 
            // FormularioImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 115);
            this.Controls.Add(this.EtiquetaEstado);
            this.Controls.Add(this.BotonImportar);
            this.Controls.Add(this.Etiqueta1);
            this.Controls.Add(this.BotonExplorar);
            this.Controls.Add(this.CampoRuta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioImportar";
            this.Text = "Importar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CampoRuta;
        private System.Windows.Forms.Button BotonExplorar;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Button BotonImportar;
        private System.Windows.Forms.Label EtiquetaEstado;
    }
}