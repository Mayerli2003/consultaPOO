using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClase27.Entidades;

namespace EjercicioClase27.Negocio
{
    class ClsOperaciones
    {
        public double suma(Operaciones operaciones)
        {
            operaciones.Resultado = operaciones.Operacion1 + operaciones.Operacion2;
            return operaciones.Resultado;
        }
        public double resta ( Operaciones operaciones)
        {
            operaciones.Resultado = operaciones.Operacion1 - operaciones.Operacion2;
            return operaciones.Resultado;
        }
        public double division(Operaciones operaciones)
        {
            operaciones.Resultado = operaciones.Operacion1 / operaciones.Operacion2;
            return operaciones.Resultado;
        }
        public double multiplicacion( Operaciones operaciones)
        {
            operaciones.Resultado = operaciones.Operacion1 * operaciones.Operacion2;
            return operaciones.Resultado;
        }

    }
}
