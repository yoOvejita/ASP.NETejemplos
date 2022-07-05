using Microsoft.AspNetCore.Mvc;

namespace ASP.NETejemplos.Controllers
{
    public class QueriesStringController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2([FromQuery(Name ="v")] string video)
        {
            ViewBag.video = video;
            return View("index2");
        }
        public IActionResult Index3([FromQuery(Name = "v2")] string video, [FromQuery(Name ="t")] int segundos)
        {
            ViewBag.video = video;
            ViewBag.tiempo = segundos;
            return View("index3");
        }

        public IActionResult Index4()
        {
            string vid = HttpContext.Request.Query["v2"].ToString();
            int seg = int.Parse(HttpContext.Request.Query["t"].ToString());
            ViewBag.video = vid;
            ViewBag.tiempo = seg;
            return View("index4");
        }
    }
}
