using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }

        public string Nombre { get; set; }
    }
}