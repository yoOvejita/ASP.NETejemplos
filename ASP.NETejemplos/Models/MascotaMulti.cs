using System.Collections.Generic;

namespace ASP.NETejemplos.Models
{
    public class MascotaMulti
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public List<string> imagenes { get; set; }
    }
}
