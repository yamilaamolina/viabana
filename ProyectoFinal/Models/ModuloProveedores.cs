using System.Collections.Generic;
using System.Web.Mvc;

namespace ProyectoFinal.Models
{
    public class ModuloProveedores
    {
        public List<Proveedor> ListaProveedores { get; set; }

        public List<SelectListItem> ListaComboBox { get; set; }
    }
}