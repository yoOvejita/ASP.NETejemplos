namespace ASP.NETejemplos.Models
{
    public class Empleado
    {
        [Key]
        public int ci { get; set; }
        [Required]
        [MaxLength(40)]
        public string nombre { get; set; }
        [Required]
        [MaxLength(40)]
        public string apellido { get; set; }
        public int telefono { get; set; }
        
        [MaxLength(70)]
        public string email { get; set; }
    }
}
