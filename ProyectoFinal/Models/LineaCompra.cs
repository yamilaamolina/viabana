using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class LineaCompra
    {
        public int ProductoID { get; set; }
        public string DescripcionProducto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
    }
}