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

        public static bool Importar(string rutaActual, string rutaOrigen)
        {
            bool result;
            string line;

            try
            {
                StreamWriter sw = new StreamWriter(rutaActual, true);
                StreamReader sr = new StreamReader(rutaOrigen);

                do
                {
                    line = sr.ReadLine();
                    sw.WriteLine(line);
                }
                while (line != null);

                sw.Close();
                sr.Close();

                result = true;
            }

            catch
            {
                result = false;
            }

            return result;
        }

        public static bool Exportar(string rutaDefault, string rutaDestino)
        {
            bool result = false;
            string completeRoute = rutaDestino + @"\export.csv";


            try
            {
                StreamWriter sw = File.CreateText(completeRoute);
                StreamReader sr = new StreamReader(rutaDefault);

                string line;

                while (true)
                {
                    line = sr.ReadLine();
                    if (line != null && VerificarAsistencia(line))
                    {
                        string[] atributos = line.Split(';');
                        sw.WriteLine("{0};{1};{2};{3};{4}", atributos[0], atributos[1], atributos[2], atributos[3], atributos[4]);
                    }
                    else
                    {
                        break;
                    }
                }

                sw.Close();
                sr.Close();

                result = true;
            }

            catch
            {

            }
            return result;
        }

        private static bool Verificar(string line, long CC)
        {
            bool result = false;
            if (line.Split(';')[0] == CC.ToString())
            {
                result = true;
            }
            return result;
        }

        private static bool VerificarAsistencia(string line)
        {
            bool result = false;
            if(line.Split(';')[5] == "1")
            {
                result = true;
            }
            return result;
        }
    }
}
