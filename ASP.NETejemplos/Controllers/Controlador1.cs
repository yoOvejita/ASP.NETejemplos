using Microsoft.AspNetCore.Mvc;

namespace ASP.NETejemplos.Controllers
{
    public class Controlador1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
