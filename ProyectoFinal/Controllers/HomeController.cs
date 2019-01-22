using ProyectoFinal.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Modulos()
        {
            return PartialView("Partials/_Modulos");
        }

        public ActionResult Compra()
        {
            return View("Modules/Compra", ObtenerListaProveedores());
        }

        public ActionResult Venta()
        {
            return View("Modules/Venta");
        }

        public ActionResult Proveedor()
        {
            return View("Modules/Proveedor", ObtenerListaProveedores());
        }

        public ActionResult Personal()
        {
            return View("Modules/Personal");
        }

        private ModuloProveedores ObtenerListaProveedores()
        {
            var proveedor1 = new Proveedor();
            var proveedor2 = new Proveedor();
            var proveedor3 = new Proveedor();
            var listaProveedoresAux = new List<Proveedor>();
            var listaProveedores = new ModuloProveedores();

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

            listaProveedores.ListaProveedores = listaProveedoresAux;

            return listaProveedores;
        }

        private ModuloCompras ObtenerListaProductos()
        {
            var producto1 = new Producto();
            var producto2 = new Producto();
            var producto3 = new Producto();

            var listaAux = new List<Producto>();
            var listaProductos = new ModuloCompras();

            producto1.NombreProducto = "Crema Cookie 10Kg";
            producto1.PrecioCompra = 750.00;
            producto1.PrecioVenta = 0;
            producto1.ProductoId = 1;
            listaAux.Add(producto1);

            producto2.NombreProducto = "Crema Americana 10Kg";
            producto2.PrecioCompra = 750.00;
            producto2.PrecioVenta = 0;
            producto2.ProductoId = 2;
            listaAux.Add(producto2);

            producto1.NombreProducto = "Chocolate amargo 10Kg";
            producto1.PrecioCompra = 800.00;
            producto1.PrecioVenta = 0;
            producto1.ProductoId = 3;
            listaAux.Add(producto3);

            listaProductos.ListaProductos = listaAux;
            return listaProductos;
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

            listaCombobox.Add(new SelectListItem { Value = "1", Text = proveedor1.RazonSocial});
            listaCombobox.Add(new SelectListItem { Value = "2", Text = proveedor2.RazonSocial});
            listaCombobox.Add(new SelectListItem { Value = "3", Text = proveedor3.RazonSocial});

            listaProveedores.ListaComboBox = listaCombobox;

            return listaProveedores;
        }
    }

}