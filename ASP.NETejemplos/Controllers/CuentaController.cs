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
            var cargos = new List<Cargo>() {
                new Cargo{id = "c0", nombre="auxiliar"},
                new Cargo{id = "c1", nombre="consultor"},
                new Cargo{id = "c2", nombre="tecnico"}
            };
            cuentavm.cargos = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(cargos, "id", "nombre");
            return View("Index",cuentavm);
        }

        [HttpPost]
        public  IActionResult Guardar(CuentaVM cvm, List<Lenguaje> lenguajes)
        {
            cvm.cuenta.lenguajes = new List<string>();
            foreach(var len in lenguajes)
                if (len.tickeado)
                    cvm.cuenta.lenguajes.Add(len.id);
            ViewBag.c = cvm.cuenta;
            return View("Registrado");
        }

        [HttpPost]
        public IActionResult destino1()
        {
            return View("destino1");
        }
        [HttpPost]
        public IActionResult destino2()
        {
            return View("destino2");
        }
        [HttpPost]
        public IActionResult destino3()
        {
            return View("destino3");
        }
    }
}
