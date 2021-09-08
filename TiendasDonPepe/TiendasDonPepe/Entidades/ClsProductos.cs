using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendasDonPepe.Entidades
{
    class ClsProductos
    {
        private int id;
        private double monto_precio;
        private double total;

        public ClsProductos() { }
        public ClsProductos(int id, double monto_precio, double total)
        {
            this.id = id;
            this.monto_precio = monto_precio;
            this.total = total;
        }

        public int Id { get => id; set => id = value; }
        public double Monto_precio { get => monto_precio; set => monto_precio = value; }
        public double Total { get => total; set => total = value; }
    }
}



