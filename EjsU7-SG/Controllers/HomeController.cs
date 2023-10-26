using EjsU7_SG.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjsU7_SG.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var fechaActual = DateTime.Now;
            var message = "Buenos días";

            if (fechaActual.Hour >= 14)
            {
                message = "Buenas tardes";
            } else if (fechaActual.Hour >= 21)
            {
                message = "Buenas noches";
            }

            ViewData["Message"] = message;
            ViewBag.fechaLarga = fechaActual.ToLongDateString();
            return View(persona);
        }

        private clsPersona persona = new clsPersona()
        {
            Id = 1,
            Nombre = "Francisco",
            Apellidos = "Rodríguez",
            Direccion = "Mi calle",
            FechaNac = new DateTime(2003, 04, 27),
            Tlfn = 654444089,
        };
    }

}