using System.ComponentModel.DataAnnotations;

namespace ClientTvShowsCoreOAuth.Models
{
    public class Serie
    {
        [Key]
        public int IdSerie { get; set; }

        public string Titulo { get; set; }

        public string Imagen { get; set; }

        [Display(Name = "Puntuación")]
        public float Puntuacion { get; set; }

        [Display(Name = "Año de estreno")]
        public int Year { get; set; }
    }
}
