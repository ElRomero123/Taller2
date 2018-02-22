using System.IO;
using EN = Entidad;

namespace Escritura
{
    public class Escritura
    {
        public static bool EscribirAsistente(EN.Asistente Asistente, string ruta)
        {
            bool result;
           
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
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

        public static EN.Asistente BuscarAsistente(long CC, string ruta)
        {
            string line;
            EN.Asistente Asistente;

            try
            {
                StreamReader sr = new StreamReader(ruta);

                do
                {
                    line = sr.ReadLine();

                    if(Verificar(line, CC))
                    {
                        break;
                    }
                }
                while (line != null);

                sr.Close();

                string[] datos = line.Split(';');

                Asistente = new EN.Asistente
                {
                    CC = long.Parse(datos[0]),
                    Nombre = datos[1],
                    Apellido = datos[2],
                    Telefono = datos[3],
                    Email = datos[4],
                    Asistencia = int.Parse(datos[5])
                };
            }

            catch
            {
                Asistente = null;
            }

            return Asistente;
        }

        public static bool Verificar(string line, long CC)
        {
            bool result = false;
            if (line.Split(';')[0] == CC.ToString())
            {
                result = true;
            }
            return result;
        }
    }
}
