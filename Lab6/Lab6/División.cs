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
        protected Persona persona_cargo;
        protected string clase;
        public División(string nombre, Persona persona_cargo)
        {
            this.nombre = nombre;
            this.Persona_cargo = persona_cargo;
        }
        public string Nombre
        {
            get => nombre; set => nombre = value;
        }
        public Persona Persona_cargo
        {
            get => persona_cargo; set => persona_cargo = value;
        }
        public string Clase
        {
            get => clase; set => clase = value;
        }
        protected List<Persona> personal;
        public List<Persona> Personal
        {
            get => personal; set => personal = value;
        }
    }
}
