using ASP.NETejemplos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;

namespace ASP.NETejemplos.Controllers
{
    public class MascotaController : Controller
    {
        private IWebHostEnvironment ihostingEnvironment;
        public MascotaController(IWebHostEnvironment ihostingEnvironment) {
            this.ihostingEnvironment = ihostingEnvironment;
        }
        public IActionResult Index()
        {

            return View("Index", new Mascota());
        }
        public IActionResult IndexMulti()
        {

            return View("IndexMulti", new MascotaMulti());
        }
        [HttpPost]
        public IActionResult Guardar(Mascota m, IFormFile img)
        {
            if (!ModelState.IsValid)
                return View("Index");
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

        [HttpPost]
        public IActionResult GuardarMultiple(MascotaMulti m, IFormFile[] imgs)
        {
            if (imgs == null || imgs.Length == 0)
                return Content("Debe subir por lo menos una imagen!!!");
            else
            {
                m.imagenes = new List<string>();
                foreach (IFormFile img in imgs) {
                    string ubicacion = Path.Combine(ihostingEnvironment.WebRootPath, "imagenes", img.FileName);// C:\Usuarios\proy\wwwroot\imagenes\perrito.jpg
                    var stream = new FileStream(ubicacion, FileMode.Create);
                    img.CopyToAsync(stream);
                    m.imagenes.Add(img.FileName);// perrito.jpg
                }
            }
            ViewBag.mascotas = m;
            return View("RegistradoMulti");
        }
    }
}
