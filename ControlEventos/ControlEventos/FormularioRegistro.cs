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
            EscribirAsistente( E.Escritura.BuscarAsistente( long.Parse(CampoCC.Text), @"E:\Universidad20181\Plataformas\BDTaller2.csv") );
        }

        private void BotonNuevo_Click(object sender, EventArgs e)
        {
            EN.Asistente Asistente = CrearAsistente();

            if (E.Escritura.EscribirAsistente(Asistente, @"E:\Universidad20181\Plataformas\BDTaller2.csv") )
            {
                EtiquetaEstado.Text = "Asistente ingresado correctamente!";
            }
        }

        private void BotonOK_Click(object sender, EventArgs e)
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
                Email = CampoEmail.Text,
                Asistencia = 1     
            };

            return Asistente;
        }

        private void EscribirAsistente(EN.Asistente Asistente)
        {
            if (Asistente != null)
            {
                CampoCC.Text = Asistente.CC.ToString();
                CampoNombre.Text = Asistente.Nombre;
                CampoApellido.Text = Asistente.Apellido;
                CampoTelefono.Text = Asistente.Telefono;
                CampoEmail.Text = Asistente.Email;

                if (Asistente.Asistencia == 1)
                {
                    EtiquetaAsistencia.Text = "Asistió";
                }

                else
                {
                    EtiquetaAsistencia.Text = "NO Asistió";
                }
            } 
        }

        private void BotonImportar_Click(object sender, EventArgs e)
        {
            FormularioImportar Importar = new FormularioImportar();
            Importar.Show();
            SetVisibleCore(true);
        }

        private void BotonExportar_Click(object sender, EventArgs e)
        {
            FormularioExportar Exportar = new FormularioExportar();
            Exportar.Show();
            SetVisibleCore(true);
        }

        /*
        private void EliminarRegistro()
        {
            E.Escritura.BuscarAsistente
        }
        */
    }
}
