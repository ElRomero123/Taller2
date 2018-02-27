using System;
using System.Windows.Forms;
using E = Escritura;

namespace ControlEventos
{
    public partial class FormularioImportar : Form
    {
        public FormularioImportar()
        {
            InitializeComponent();
        }
        private void BotonExplorar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Explorador = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Documentos (CSV, TXT)|*.csv;*.txt"
            };


            if (Explorador.ShowDialog() == DialogResult.OK)
            {
                CampoRuta.Text = Explorador.FileName.ToString();
            }
        }
        private void BotonImportar_Click(object sender, EventArgs e)
        {
            if(E.Escritura.Importar(@"C:\Users\Juan Pablo\Desktop\CSVDatos.csv", CampoRuta.Text))
            {
                EtiquetaEstado.Text = "Se ha importado correctamente la información!";
            }

            else
            {
                EtiquetaEstado.Text = "NO se puede importar la información!";
            }
        }
    }
}
