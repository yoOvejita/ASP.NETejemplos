using ASP.NETejemplos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ASP.NETejemplos.Controllers
{
    public class MascotaController : Controller
    {
        private IHostingEnvironment ihostingEnvironment;
        public MascotaController(IHostingEnvironment ihostingEnvironment) {
            this.ihostingEnvironment = ihostingEnvironment;
        }
        public IActionResult Index()
        {

            return View("Index", new Mascota());
        }
        [HttpPost]
        public IActionResult Guardar(Mascota m, IFormFile img)
        {
            if (img == null || img.Length == 0)
                return Content("Debe subir una imagen!!!");
            else
            {
                string ubicacion = Path.Combine(ihostingEnvironment.WebRootPath, "imagenes", img.FileName);// C:\Usuarios\proy\wwwroot\imagenes\perrito.jpg
                var stream = new FileStream(ubicacion, FileMode.Create);
                img.CopyToAsync(stream);
                m.imagen = img.FileName;// perrito.jpg
            }
            ViewBag.mascota = m;
            return View("Registrado");
        }
    }
}
