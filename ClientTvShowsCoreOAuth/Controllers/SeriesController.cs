using ClientTvShowsCoreOAuth.Models;
using ClientTvShowsCoreOAuth.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientTvShowsCoreOAuth.Controllers
{
    [Route("[controller]/[action]")]
    public class SeriesController : Controller
    {
        private readonly ApplicationRepository _repo;

        public SeriesController(ApplicationRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("/Series")]
        [Route("~/Series/Index")]
        public async Task<IActionResult> Index()
        {
            List<Serie> query = await _repo.GetSeries();
            List<Serie> series = query.OrderBy(p => p.Titulo).ToList();

            return View(series);
        }

        [HttpGet("{idserie}")]
        public async Task<IActionResult> Details(int idserie)
        {
            Serie serie = await _repo.GetSerie(idserie);

            return View(serie);
        }
    }
}
