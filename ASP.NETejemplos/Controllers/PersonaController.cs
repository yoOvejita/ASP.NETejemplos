using Microsoft.AspNetCore.Mvc;
using System;

namespace ASP.NETejemplos.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.edad = 18;
            ViewBag.nombre = "Pepe";
            ViewBag.casado = false;
            ViewBag.estatura = 1.8;
            ViewBag.fecha_nac = DateTime.Now;
            return View();
        }
    }
}
