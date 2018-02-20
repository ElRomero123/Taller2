using System;
using System.Windows.Forms;
using E = Escritura;
using EN = Entidad;

namespace ControlEventos
{
    public partial class FormularioRegistro : Form
    {
        public FormularioRegistro()
        {
            InitializeComponent();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BotonNuevo_Click(object sender, EventArgs e)
        {
            EN.Asistente Asistente = CrearAsistente();

            if (E.Escritura.EscribirAsistente(Asistente))
            {
                EtiquetaEstado.Text = "Asistente ingresado correctamente!";
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {

        }

        private EN.Asistente CrearAsistente()
        {
            EN.Asistente Asistente = new EN.Asistente
            {
                CC = long.Parse(CampoCC.Text),
                Nombre = CampoNombre.Text,
                Apellido = CampoApellido.Text,
                Telefono = CampoTelefono.Text,
                Email = CampoEmail.Text
            };

            return Asistente;
        }
    }
}
