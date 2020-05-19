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
        public Bloque(string nombre, Persona Persona_a_cargo, List<Persona> personal) : base(nombre, Persona_a_cargo)
        {
            this.Clase = "Bloque";
            this.nombre = nombre;
            this.Persona_a_cargo = Persona_a_cargo;
            this.Personal = personal;
        }
    }
}
