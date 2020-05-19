using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab6
{
    [Serializable]
    public class Área:División
    {
        public Área(string nombre, Persona Persona_a_cargo):base(nombre, Persona_a_cargo)
        {
            this.Clase = "Área";
            this.nombre = nombre;
            this.Persona_a_cargo = persona_a_cargo;
        }
    }
}
