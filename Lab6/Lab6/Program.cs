using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Lab6
{
    class MainClass
    {

        static private void cargar_empresa(Empresa empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            empresa = (Empresa)formatter.Deserialize(stream);
            stream.Close();
            Empresa.datos_empresa(empresa);

        }
        static private void guardar_empresa(Empresa empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa);
            stream.Close();
        }
        public static void Main(string[] args)
        {
            List<Persona> personas_a_cargo = new List<Persona>();
            List<Persona> personal = new List<Persona>();
            Persona p1 = new Persona("tony", "stark", "10405943-4", "Persona a cargo");
            personas_a_cargo.Add(p1);
            Persona p2 = new Persona("peter", "parker", "12493495-6", "Persona a cargo");
            personas_a_cargo.Add(p2);
            Persona p3 = new Persona("lionel", "messi", "14859405-k", "Persona a cargo");
            personas_a_cargo.Add(p3);
            Persona p4 = new Persona("Cristiano", "Ronaldo", "15498586-5", "Persona a cargo");
            personas_a_cargo.Add(p4);
            Persona p5 = new Persona("alessandra", "ambrossio", "13847596-6", "personal");
            personal.Add(p5);
            Persona p6 = new Persona("adriana", "lima", "14856485-0", "personal");
            personal.Add(p6);
            Persona p7 = new Persona("megan", "fox", "17597495-7", "personal");
            personal.Add(p7);
            Persona p8 = new Persona("ester", "exposito", "20174859-6", "personal");
            personal.Add(p8);
            Persona p9 = new Persona("mathild", "tantot", "20375947-k", "personal");
            personal.Add(p9);
            Empresa empresa = new Empresa();
            Console.WriteLine("Bienvenido");
            Console.WriteLine("¿Quiere utilizar un archivo para cargar la información de la empresa?");
            Console.WriteLine("1) Si");
            Console.WriteLine("2) No");
            Console.WriteLine("3) Salir del programa");
            string input = Console.ReadLine();
            if (input == "1")
            {
                try
                {
                    cargar_empresa(empresa);
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("\nNo se pudo abrir el archivo");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("no hay ninguna empresa guardada, por favor cree una");
                    Empresa n_empresa = Empresa.Crear_empresa(personas_a_cargo, personal);
                    Empresa.datos_empresa(n_empresa);
                    guardar_empresa(n_empresa);
                    Console.WriteLine("Se guardó la empresa solicitada");
                }
            }
            else if (input == "2")
            {
                Empresa n_empresa = Empresa.Crear_empresa(personas_a_cargo, personal);
                Empresa.datos_empresa(n_empresa);
                guardar_empresa(n_empresa);
                Console.WriteLine("Se guardó la empresa solicitada");
            }
            else if (input == "3")
            {
                Console.WriteLine("Hasta pronto");
            }
            else
            {
                Console.WriteLine("Criterio ingresado no válido, por favor ingrese uno que si lo sea.");
                Console.WriteLine("");
                Console.WriteLine("¿Quiere utilizar un archivo para cargar la información de la empresa?");
                Console.WriteLine("1) Si");
                Console.WriteLine("2) No");
                input = Console.ReadLine();
            }
            Console.WriteLine("");
            
            
        }

    }
}
