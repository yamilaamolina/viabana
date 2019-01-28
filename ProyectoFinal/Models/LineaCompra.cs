using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class LineaCompra
    {
        public int Cantidad { get; set; }
        public Producto Producto { get; set; }
        public double Subtotal { get; set; }
    }
}