using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab6
{
    [Serializable]
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string rut;
        protected string cargo;
        public Persona(string nombre, string apellido, string rut, string cargo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Rut = rut;
            this.Cargo = cargo;
        }
        public string Nombre
        {
            get => nombre; set => nombre = value;
        }
        public string Apellido
        {
            get => apellido; set => apellido = value;
        }
        public string Rut
        {
            get => rut; set => rut = value;
        }
        public string Cargo
        {
            get => cargo; set => cargo = value;
        }
    }
}
