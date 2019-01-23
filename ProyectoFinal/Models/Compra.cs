using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class Compra
    {
        public int CompraID { get; set; }
        public Proveedor Proveedor { get; set; }
        public List<LineaCompra> ListaProductos { get; set; }
    }
}