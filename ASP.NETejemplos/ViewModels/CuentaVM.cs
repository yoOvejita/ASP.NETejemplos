using ASP.NETejemplos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ASP.NETejemplos.ViewModels
  
{
    public class CuentaVM
    {
        public Cuenta cuenta { get; set; }
        public List<Lenguaje> lenguajes { get; set; }
        public SelectList cargos { get; set; }
    }
}
