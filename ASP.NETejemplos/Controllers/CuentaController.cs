using ASP.NETejemplos.Models;
using ASP.NETejemplos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP.NETejemplos.Controllers
{
    public class CuentaController : Controller
    {
        public IActionResult Index()
        {
            CuentaVM cuentavm = new CuentaVM();
            cuentavm.cuenta = new Cuenta() { id = 304, casado=true, genero="masculino" };
            cuentavm.lenguajes = new List<Lenguaje>() {
                new Lenguaje(){ id="1", nombre="C++", tickeado = false},
                new Lenguaje(){ id="2", nombre="C#", tickeado = true},
                new Lenguaje(){ id="3", nombre="Java", tickeado = false},
                new Lenguaje(){ id="4", nombre="Python", tickeado = true}
            };
            return View();
        }
    }
}
