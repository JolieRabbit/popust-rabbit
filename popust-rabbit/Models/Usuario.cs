using System.ComponentModel.DataAnnotations;

namespace popust_rabbit.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }
        public object Id { get; internal set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        [Display(Name = "Administrador")]
        Administrador,
        [Display(Name = "Usuario")]
        Usuario
    }

}
