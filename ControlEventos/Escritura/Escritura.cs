using System.IO;
using EN = Entidad;

namespace Escritura
{
    public class Escritura
    {
        public static bool EscribirAsistente(EN.Asistente Asistente)
        {
            bool result;
            StreamWriter sw = new StreamWriter(@"C:\Users\Juan Pablo\Desktop\Nuevo documento de texto.txt", true);

            try
            {
                sw.WriteLine("{0};{1};{2};{3};{4};{5}", Asistente.CC.ToString(), Asistente.Nombre, Asistente.Apellido, Asistente.Telefono, Asistente.Email, Asistente.Asistencia);
                sw.Close();
                result = true;
            }

            catch
            {
                result = false;
            }

            return result;
        }
    }
}
