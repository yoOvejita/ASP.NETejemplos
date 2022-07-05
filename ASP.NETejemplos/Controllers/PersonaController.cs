using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ASP.NETejemplos.Controllers
{
    [Route("Ciudadano")]
    public class PersonaController : Controller
    {
        [Route("indice")]
        public IActionResult Index()
        {
            ViewBag.edad = 18;
            ViewBag.nombre = "Pepe";
            ViewBag.casado = false;
            ViewBag.estatura = 1.8;
            ViewBag.fecha_nac = DateTime.Now;
            return View();
        }
        [Route("valores/{edad}/{estatura}")]
        public IActionResult PruebasAppSettings(int edad, double estatura)
        {
            var constructor = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuracion = constructor.Build();
            ViewBag.valor1 = configuracion["ValorClave"];
            ViewBag.valor2 = configuracion["MisAjustes:ajusteDev"];
            ViewBag.valor3 = configuracion["MisAjustes:ajusteProd"];
            ViewBag.valor4 = configuracion["MisAjustes:ajusteDebug"];
            ViewBag.valor5 = configuracion["Logging:LogLevel:Microsoft"];
            ViewBag.valor6 = edad;
            ViewBag.valor7 = estatura;
            return View();
        }
    }
}
