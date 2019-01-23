using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Producto
    {
        [Key]

        public int idProducto { get; set; }

        public String descripcion { get; set; }

        public double precio { get; set; }

        public String estado { get; set; }

    }
}