using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        public string NombreProducto { get; set; }

        public double PrecioCompra { get; set; }

        public double PrecioVenta { get; set; }
    }
}