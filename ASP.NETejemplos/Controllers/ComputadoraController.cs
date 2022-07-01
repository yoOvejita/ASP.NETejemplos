using ASP.NETejemplos.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETejemplos.Controllers
{
    public class ComputadoraController : Controller
    {
        public IActionResult Index()
        {
            Computadora c = new Computadora() { 
                id = "comp01",
                nombre = "Laptop Toshiba",
                imagen = "comp01.jpg",
                precio = 1300.5,
                cantidad = 10
            };
            ViewBag.computadora = c;
            return View();
        }
    }
}
