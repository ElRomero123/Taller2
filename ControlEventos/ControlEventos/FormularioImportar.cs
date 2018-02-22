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

        private void BotonImportar_Click(object sender, EventArgs e)
        {
            if(E.Escritura.Importar(@"C:\Users\Juan Pablo\Desktop\CSVDatos.csv", CampoRuta.Text))
            {
                
            }
            else
            {

            }
        }
    }
}
