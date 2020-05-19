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
    [Serializable]
    public class Empresa
    {
        protected string nombre;
        protected string rut;
        public Empresa(string nombre, string rut, List<División> todas_divisiones)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.Todas_divisiones = todas_divisiones;
        }
        public string Nombre
        {
            get => nombre; set => nombre = value;
        }
        public List<División> Todas_divisiones
        {
            get => todas_divisiones; set => todas_divisiones = value;
        }
        public string Rut
        {
            get => rut; set => rut = value;
        }
        public Empresa()
        {
        }
        protected List<División> todas_divisiones;
        public static void datos_empresa(Empresa empresa)
        {
            Console.WriteLine("El nombre de la empresa es: " + empresa.Nombre);
            Console.WriteLine("El nombre de la empresa es: " + empresa.Rut);
            Console.WriteLine("Las divisiones de la empresa son:");
            foreach (División división in empresa.todas_divisiones)
            {
                Console.WriteLine("El tipo de la división es : " + división.Clase);
                Console.WriteLine("El nombre de la división es : " + división.Nombre);
                Console.WriteLine("El encargado de la división es : " + división.Persona_cargo.Nombre + " " + división.Persona_cargo.Apellido + ", " + división.Persona_cargo.Rut);
                if (división.Clase == "Bloque")
                {
                    Console.WriteLine("El personal que hay en los bloques es:");
                    foreach (Persona persona in división.Personal)
                    {
                        Console.WriteLine(persona.Nombre + " " + persona.Apellido + ", " + persona.Rut);
                    }
                }
            }
        }
        public static Empresa Crear_empresa(List<Persona> persona_a_cargo, List<Persona> personal)
        {
            Console.Write("Nombre de la empresa:  ");
            string nombre_empresa = Console.ReadLine();
            Console.Write("Rut de la empresa(Con guión y sin puntos):  ");
            string rut_empresa = Console.ReadLine();
            List<Persona> persona_a_cargo1 = new List<Persona>();
            List<Persona> personal1 = new List<Persona>();
            persona_a_cargo1 = Renovar(persona_a_cargo);
            personal1 = Renovar(personal);
            Sección sección = new Sección("Sección POO", persona_a_cargo1[1]);
            List<Persona> bloque1 = new List<Persona>() { personal1[0], personal1[1] };
            Bloque Bloque1 = new Bloque("Bloque POO 1", persona_a_cargo1[2], bloque1);
            List<Persona> bloque2 = new List<Persona>() { personal1[2], personal1[3] };
            Bloque Bloque2 = new Bloque("Bloque POO 2", persona_a_cargo1[3], bloque2);
            Departamento departamento = new Departamento("Departamento POO", persona_a_cargo1[0]);
            Empresa empresa = new Empresa(nombre_empresa, rut_empresa, new List<División>() {departamento, sección, Bloque1, Bloque2});
            return empresa;
        }
        public static List<Persona> Renovar<Persona>(List<Persona> p)
        {
            List<Persona> persona_a_cargo = p;
            List<Persona> renovada = new List<Persona>();
            Random azar = new Random();
            while (persona_a_cargo.Count > 0)
            {
                int i = azar.Next(0, persona_a_cargo.Count - 1);
                renovada.Add(persona_a_cargo[i]);
                persona_a_cargo.RemoveAt(i);
            }
            return renovada;
        }
    }
}
    

