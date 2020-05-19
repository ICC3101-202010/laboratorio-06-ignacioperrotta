using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab6
{
    [Serializable]
    public class Bloque : División
    {
        protected List<Persona> personal;
        public Bloque(string nombre, Persona persona_cargo, List<Persona> personal) : base(nombre, persona_cargo)
        {
            this.Clase = "Bloque";
            this.nombre = nombre;
            this.Persona_cargo = persona_cargo;
            this.Personal = personal;
        }
        public List<Persona> Personal
        {
            get => personal; set => personal = value;
        }
    }
}
