﻿using ProyectoFinal.Models;
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
            return View("Modules/Compra",ObtenerDatosDeCompras());
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

        private ModuloCompras ObtenerDatosDeCompras()
        {
            var proveedor1 = new Proveedor();
            var proveedor2 = new Proveedor();
            var proveedor3 = new Proveedor();
            var listaProveedoresAux = new List<Proveedor>();
            var listaModuloCompra = new ModuloCompras();

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

            listaModuloCompra.ListaProveedores = listaProveedoresAux;

            var producto1 = new Producto();
            var producto2 = new Producto();
            var producto3 = new Producto();

            var lineadecompra1 = new LineaCompra();
            var lineadecompra2 = new LineaCompra();
            var lineadecompra3 = new LineaCompra();
            var lineadecompraAux1 = new List<LineaCompra>();
            var lineadecompraAux2 = new List<LineaCompra>();

            var compra1 = new Compra();
            var compra2 = new Compra();

            producto1.IdProducto = 1;
            producto1.NombreProducto = "Coca";
            producto1.Precio = 80;

            producto2.IdProducto = 2;
            producto2.NombreProducto = "Fanta";
            producto2.Precio = 90;

            producto3.IdProducto = 3;
            producto3.NombreProducto = "Sprite";
            producto3.Precio = 70;

            lineadecompra1.Producto = producto1;
            lineadecompra1.Cantidad = 3;
            lineadecompra1.Subtotal = lineadecompra1.Producto.Precio * lineadecompra1.Cantidad;

            lineadecompra2.Producto = producto2;
            lineadecompra2.Cantidad = 2;
            lineadecompra2.Subtotal = lineadecompra2.Producto.Precio * lineadecompra2.Cantidad;

            lineadecompra3.Producto = producto3;
            lineadecompra3.Cantidad = 4;
            lineadecompra3.Subtotal = lineadecompra3.Producto.Precio * lineadecompra3.Cantidad;

            lineadecompraAux1.Add(lineadecompra1);
            lineadecompraAux1.Add(lineadecompra2);

            lineadecompraAux2.Add(lineadecompra2);
            lineadecompraAux2.Add(lineadecompra3);

            compra1.IdCompra = 1;
            compra1.Proveedor = proveedor1;
            compra1.FechaCompra = DateTime.Now;
            compra1.LineaDeCompra = lineadecompraAux1;
            double totalcompra1 = 0;
            foreach (var lineadecompra in compra1.LineaDeCompra)
            {
                totalcompra1 = totalcompra1 + lineadecompra.Subtotal;  
            }
            compra2.TotalCompra = totalcompra1;

            compra2.IdCompra = 2;
            compra2.Proveedor = proveedor3;
            compra2.FechaCompra = DateTime.Now;
            compra2.LineaDeCompra = lineadecompraAux2;
            double totalcompra2 = 0;
            foreach (var lineadecompra in compra2.LineaDeCompra)
            {
                totalcompra2 = totalcompra2 + lineadecompra.Subtotal;
            }
            compra1.TotalCompra = totalcompra2;

            var ListaDeCompraAux = new List<Compra>();
            ListaDeCompraAux.Add(compra1);
            ListaDeCompraAux.Add(compra2);

            listaModuloCompra.ListaDeCompra = ListaDeCompraAux;

            return listaModuloCompra;
        }
    }
}