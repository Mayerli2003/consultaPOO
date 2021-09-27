using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase27.Entidades
{
    class Profesor
    {
        private string titulo;
        private string designacion;
        private string dedicacion;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Designacion { get => designacion; set => designacion = value; }
        public string Dedicacion { get => dedicacion; set => dedicacion = value; }
    }
}
