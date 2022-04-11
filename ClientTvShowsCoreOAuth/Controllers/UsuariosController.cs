using ClientTvShowsCoreOAuth.Filters;
using ClientTvShowsCoreOAuth.Models;
using ClientTvShowsCoreOAuth.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClientTvShowsCoreOAuth.Controllers
{
    [Route("[controller]/[action]")]
    public class UsuariosController : Controller
    {
        private readonly ApplicationRepository _repo;

        public UsuariosController(ApplicationRepository repo)
        {
            _repo = repo;
        }

        [UsuariosAuthorize]
        [HttpGet]
        [Route("/Usuarios")]
        [Route("~/Usuarios/Index")]
        public async Task<IActionResult> Index()
        {
            string token = HttpContext.Session.GetString("TOKEN");
            Usuario usuario = await _repo.PerfilUsuario(token);

            return View(usuario);
        }
    }
}
