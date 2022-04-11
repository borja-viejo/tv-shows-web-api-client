using System.ComponentModel.DataAnnotations;

namespace ClientTvShowsCoreOAuth.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        [EmailAddress(ErrorMessage = "La Dirección de E-mail no es válida")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Dirección de E-mail")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}
