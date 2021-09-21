using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.Negocio
{
    class ClsPersona
    {
        public string MostrarNombre(Persona persona )
        {
            return persona.Nombre;
        }
        public int Acceso(Persona persona)
        {
            if(persona.Nombre=="Maye" && persona.Contra == "123")
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
