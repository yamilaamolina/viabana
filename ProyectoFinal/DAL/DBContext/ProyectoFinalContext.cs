using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoFinal.DAL.DBContext
{
    public class ProyectoFinalContext : DbContext
    {
        public ProyectoFinalContext() :base("GestionFinal")
        {

        }

        //Compra
        public DbSet<Compra> Compras { get; set; }
        public DbSet<LineaCompra> LineaCompras { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
    }
}