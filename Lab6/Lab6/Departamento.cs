﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab6
{
    [Serializable]
    public class Departamento : División
    {
        public Departamento(string nombre, Persona persona_cargo) : base(nombre, persona_cargo)
        {
            this.Clase = "Departamento";
            this.nombre = nombre;
            this.Persona_cargo = persona_cargo;
        }
    }
}