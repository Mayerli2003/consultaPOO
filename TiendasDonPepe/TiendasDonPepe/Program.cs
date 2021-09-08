using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendasDonPepe.Entidades;
using TiendasDonPepe.Negocios;


namespace TiendasDonPepe
{
    class Program
    {
        

        static void Main(string[] args)
        
        {
            ClsProductos productos = new ClsProductos();
            NClsProductos negocio = new NClsProductos();

            Console.WriteLine("Ingrese el dia de la semana" +
               "\n1 - Lunes" +
               "\n2- Martes" +
               "\n3 - Miercoles" +
               "\n4 - Jueves" +
               "\n5 - Viernes" +
               "\n6 - Sabado" +
               "\n7 - Domingo");
            productos.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto total ");
           
            productos.Monto_precio = int.Parse(Console.ReadLine());

            //public double totalPagar(int id, double monto_precio, double total)
             = negocio.totalPagar(id, monto_precio, total);

            



        }
    }




}
