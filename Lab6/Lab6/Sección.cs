using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab6
{
    [Serializable]
    public class Sección : División
    {
        public Sección(string nombre, Persona Persona_a_cargo) : base(nombre, Persona_a_cargo)
        {
            this.Clase = "Sección";
            this.nombre = nombre;
            this.Persona_a_cargo = Persona_a_cargo;
        }
    }
}