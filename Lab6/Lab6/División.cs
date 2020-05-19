using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab6
{
    [Serializable]
    public class División
    {
        protected string nombre;
        protected Persona persona_a_cargo;
        protected string clase;
        public División(string nombre, Persona persona_a_cargo)
        {
            this.nombre = nombre;
            this.Persona_a_cargo = persona_a_cargo;
        }
        public string Nombre
        {
            get => nombre; set => nombre = value;
        }
        public Persona Persona_a_cargo
        {
            get => persona_a_cargo; set => persona_a_cargo = value;
        }
        public string Clase
        {
            get => clase; set => clase = value;
        }
        protected List<Persona> personal;
        internal List<Persona> Personal
        {
            get => personal; set => personal = value;
        }
    }
}
