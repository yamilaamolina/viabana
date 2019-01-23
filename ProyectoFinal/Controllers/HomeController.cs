using ProyectoFinal.Models;
using System;
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
            return View("Modules/Compra");
        }

        public ActionResult Venta()
        {
            return View("Modules/Venta", ObtenerVentas());
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
        private ModuloVentas ObtenerVentas()
        {
            var venta1 = new Venta();
            var venta2 = new Venta();
            var venta3 = new Venta();
            var ListaVentasAux = new List<Venta>();
            var ListaVentas = new ModuloVentas();
            DateTime date1 = new DateTime(2010, 8, 18);

            venta1.idVenta = 15212;
            venta1.totalVenta = 121.5;
            venta1.fecha = date1;
            ListaVentasAux.Add(venta1);

            venta2.idVenta = 15212;
            venta2.totalVenta = 121.5;
            venta2.fecha = date1;
            ListaVentasAux.Add(venta2);

            venta3.idVenta = 15212;
            venta3.totalVenta = 121.5;
            venta3.fecha = date1;
            ListaVentasAux.Add(venta3);

            ListaVentas.ListaVentas = ListaVentasAux;
            return ListaVentas;

        }
    }
}