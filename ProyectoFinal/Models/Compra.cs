using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public Proveedor Proveedor { get; set; }
        public double TotalCompra { get; set; }
        public List<LineaCompra> LineaDeCompra { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}