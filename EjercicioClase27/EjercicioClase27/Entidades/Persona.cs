using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase27.Entidades
{
    class Persona
    {
        private string nombre;
        private string direccion;
        private int fechaNac;
        private string genero;
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
