using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Venta
    {
        [Key]

        public int idVenta { get; set; }

        public DateTime fecha { get; set; }

        public double totalVenta { get; set; }

        public double iva { get; set; }
    }
}