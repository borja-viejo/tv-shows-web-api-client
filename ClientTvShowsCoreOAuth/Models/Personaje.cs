using System.ComponentModel.DataAnnotations;

namespace ClientTvShowsCoreOAuth.Models
{
    public class Personaje
    {
        [Key]
        public int IdPersonaje { get; set; }

        public string Nombre { get; set; }

        public string Imagen { get; set; }

        public int IdSerie { get; set; }
    }
}
