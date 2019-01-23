using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class CompraController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Compra()
        {
            return View("Views/Home/Modules/Compra", ObtenerLista());
        }

        private ModuloProveedores ObtenerLista()
        {
            var proveedor1 = new Proveedor();
            var proveedor2 = new Proveedor();
            var proveedor3 = new Proveedor();
            var listaProveedoresAux = new List<Proveedor>();
            var listaProveedores = new ModuloProveedores();
            var listaCombobox = new List<SelectListItem>();

            proveedor1.RazonSocial = "Milkaut";
            proveedor1.CUIT = 27504659873;
            proveedor1.Telefono = "381-5478569";
            proveedor1.Email = "proveedores@milkaut.com";
            proveedor1.Direccion = "San Miguel de Tucuman";
            listaProveedoresAux.Add(proveedor1);

            proveedor2.RazonSocial = "Colorante S.A.";
            proveedor2.CUIT = 28263214563;
            proveedor2.Telefono = "381-5478569";
            proveedor2.Email = "proveedores@colorante.com";
            proveedor2.Direccion = "San Miguel de Tucuman";
            listaProveedoresAux.Add(proveedor2);

            proveedor3.RazonSocial = "Lunaa";
            proveedor3.CUIT = 27456987233;
            proveedor3.Telefono = "381-5478569";
            proveedor3.Email = "proveedores@lunaa.com";
            proveedor3.Direccion = "San Miguel de Tucuman";
            listaProveedoresAux.Add(proveedor3);

            listaCombobox.Add(new SelectListItem { Value = "1", Text = proveedor1.RazonSocial });
            listaCombobox.Add(new SelectListItem { Value = "2", Text = proveedor2.RazonSocial });
            listaCombobox.Add(new SelectListItem { Value = "3", Text = proveedor3.RazonSocial });

            listaProveedores.ListaComboBox = listaCombobox;

            return listaProveedores;
        }
    }
}