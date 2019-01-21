using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Proveedor
    {
        [Key]
        public long CUIT { get; set; }

        public string RazonSocial { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }
    }
}