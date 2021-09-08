using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendasDonPepe.Entidades;



namespace TiendasDonPepe.Negocios

{
    
    class NClsProductos

    {
        ClsProductos productos = new ClsProductos();

        
        

        public double totalPagar(int id, double monto_precio, double total)
        {
            
            if (id == 2)
            {
                double Respuesta1;
                
                Respuesta1 = monto_precio * 0.15;
                total = monto_precio - Respuesta1;
                Console.WriteLine("El total es de $" + total);
                return total;

            }
             else if (id == 4)
            {
                double Respuesta1;
                
                Respuesta1 = monto_precio * 0.15;
                total = monto_precio - Respuesta1;
                Console.WriteLine("El total es de $" + total);

                return total;
                

            }
            else
            {
                Console.WriteLine("El total es de $"+monto_precio);
                return monto_precio;
            }


        }

    
    }
}
