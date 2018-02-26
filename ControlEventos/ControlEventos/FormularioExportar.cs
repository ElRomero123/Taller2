using System;
using System.Windows.Forms;
using E = Escritura;

namespace ControlEventos
{
    public partial class FormularioExportar : Form
    {
        public FormularioExportar()
        {
            InitializeComponent();
        }

        private void BotonExplorar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Explorador = new FolderBrowserDialog();

            if (Explorador.ShowDialog() == DialogResult.OK)
            {
                CampoRuta.Text = Explorador.SelectedPath;
            }
        }

        private void BotonExportar_Click(object sender, EventArgs e)
        {
            if(E.Escritura.Exportar(@"E:\Universidad20181\Plataformas\BDTaller2.csv", CampoRuta.Text))
            {

            }
            else
            {

            }
        }
    }
}
