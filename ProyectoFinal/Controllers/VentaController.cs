using ProyectoFinal.Models;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class VentaController : Controller
    {
        public ActionResult Index()
        {
            return View("Modals/VentaModal");
        }

    }
}