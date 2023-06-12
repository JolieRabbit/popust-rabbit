using System.ComponentModel.DataAnnotations;

namespace popust_rabbit.Models
{
    public class UsuarioDto
    {
        public int ? ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public Perfil Perfil { get; set; }
    }
}
