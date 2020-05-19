using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;
namespace Lab6
{
    class MainClass
    {
        static private void Información_empresa(Empresa empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            empresa = (Empresa)formatter.Deserialize(stream);
            stream.Close();
            Empresa.datos_empresa(empresa);

        }
        static private void Cargar_empresa(Empresa empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa);
            stream.Close();
        }
        public static void Main(string[] args)
        {
            Empresa empresa = new Empresa();
            List<Persona> personas_a_cargo = new List<Persona>();
            List<Persona> personal = new List<Persona>();
            Console.WriteLine("¿Quiere utilizar un archivo para cargar la información de la empresa?");
            Console.WriteLine("1) Si");
            Console.WriteLine("2) No");
            string input = Console.ReadLine();
            if (input == "1")
            {
                try
                {
                    Información_empresa(empresa);
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("\nNo se pudo abrir el archivo");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("no hay ninguna empresa guardada, por favor cree una");
                    Empresa n_empresa = Empresa.Crear_empresa(personas_a_cargo, personal);
                    Empresa.datos_empresa(n_empresa);
                    Cargar_empresa(n_empresa);
                    Console.WriteLine("Se cargó la empresa solicitada");
                }
            }
            else if (input == "2")
            {
                Empresa n_empresa = Empresa.Crear_empresa(personas_a_cargo, personal);
                Empresa.datos_empresa(n_empresa);
                Cargar_empresa(n_empresa);
                Console.WriteLine("Se cargó la empresa solicitada");
            }
            else
            {
                Console.WriteLine("Criterio ingresado no válido, por favor ingrese uno que si lo sea");
                Console.WriteLine("¿Quiere utilizar un archivo para cargar la información de la empresa?");
                Console.WriteLine("1) Si");
                Console.WriteLine("2) No");
                input = Console.ReadLine();
            }
        }
    }
}
