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

        [HttpGet]
        public ActionResult DevolverLista(string index)
        {
            var listaProductos = new List<Producto>();
            if (index.Equals("27504659873"))
            {

                var producto1 = new Producto();
                var producto2 = new Producto();

                producto1.ProductoId = 1;
                producto1.NombreProducto = "Leche";
                producto1.Precio = 70.00;

                producto2.ProductoId = 2;
                producto2.NombreProducto = "Azucar";
                producto2.Precio = 70.00;

                listaProductos.Add(producto1);
                listaProductos.Add(producto2);
            }
            if (index.Equals("28263214563"))
            {
                var producto1 = new Producto();
                var producto2 = new Producto();

                producto1.ProductoId = 3;
                producto1.NombreProducto = "Cosa1";
                producto1.Precio = 70.00;

                producto2.ProductoId = 4;
                producto2.NombreProducto = "Cosa2";
                producto2.Precio = 70.00;

                listaProductos.Add(producto1);
                listaProductos.Add(producto2);
            }
            if (index.Equals("27456987233"))
            {
                var producto1 = new Producto();
                var producto2 = new Producto();

                producto1.ProductoId = 5;
                producto1.NombreProducto = "Cosa3";
                producto1.Precio = 70.00;

                producto2.ProductoId = 6;
                producto2.NombreProducto = "Cosa4";
                producto2.Precio = 70.00;

                listaProductos.Add(producto1);
                listaProductos.Add(producto2);
            }
            return PartialView(listaProductos);
        }
    }
}