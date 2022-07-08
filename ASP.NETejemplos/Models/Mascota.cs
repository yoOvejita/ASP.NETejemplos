using System.ComponentModel.DataAnnotations;

namespace ASP.NETejemplos.Models
{
    public class Mascota
    {
        [Required]
        public string id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string nombre { get; set; }
        [Required]
        [Range(10, 700)]
        public double precio { get; set; }
        //[EmailAddress] [Url]
        public string imagen { get; set; }
    }
}
