using ASP.NETejemplos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IActionResult Lista()
        {
            List<Computadora> computadoras = new List<Computadora>() {
                 new Computadora()
            {
                id = "comp01",
                nombre = "Laptop Toshiba",
                imagen = "comp01.jpg",
                precio = 1300.5,
                cantidad = 10
            },
                  new Computadora()
            {
                id = "comp02",
                nombre = "Laptop Compaq",
                imagen = "comp02.jpg",
                precio = 2000,
                cantidad = 20
            },
                   new Computadora()
            {
                id = "comp03",
                nombre = "Laptop HP",
                imagen = "comp03.jpeg",
                precio = 5050.5,
                cantidad = 5
            }
            };
            
            ViewBag.computadora = computadoras;
            return View();
        }
    }
}
