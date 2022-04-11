using ClientTvShowsCoreOAuth.Models;
using ClientTvShowsCoreOAuth.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientTvShowsCoreOAuth.Controllers
{
    [Route("[controller]/[action]")]
    public class PersonajesController : Controller
    {
        private readonly ApplicationRepository _repo;

        public PersonajesController(ApplicationRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("/Personajes")]
        [Route("~/Personajes/Index")]
        public async Task<IActionResult> Index()
        {
            List<Personaje> query = await _repo.GetPersonajes();
            List<Personaje> personajes = query.OrderBy(p => p.Nombre).ToList();

            List<Serie> series = await _repo.GetSeries();
            ViewData["Series"] = series;

            return View(personajes);
        }

        [HttpGet("{idpersonaje}")]
        public async Task<IActionResult> Details(int idpersonaje)
        {
            Personaje personaje = await _repo.GetPersonaje(idpersonaje);

            Serie serie = await _repo.GetSerie(personaje.IdSerie);
            ViewData["Titulo"] = serie.Titulo;

            return View(personaje);
        }

        [HttpGet("{idserie}")]
        public async Task<IActionResult> BySerie(int idserie)
        {
            List<Personaje> query = await _repo.GetPersonajeBySerie(idserie);
            List<Personaje> personajes = query.OrderBy(p => p.Nombre).ToList();
            ViewData["IdSerie"] = idserie;

            Serie serie = await _repo.GetSerie(idserie);
            ViewData["Titulo"] = serie.Titulo;

            return View(personajes);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            List<Serie> series = await _repo.GetSeries();
            var seriesDisplay = series.Select(x => new
            {
                Id = x.IdSerie,
                Value = x.Titulo
            }).OrderBy(x => x.Value)
            .ToList();

            var seriesList = new SelectList(seriesDisplay, "Id", "Value");
            ViewBag.Series = seriesList;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Personaje personaje)
        {
            string token = HttpContext.Session.GetString("TOKEN");

            List<Personaje> personajes = await _repo.GetPersonajes();
            Personaje lastPj = personajes.OrderBy(p => p.IdPersonaje).Last();
            personaje.IdPersonaje = lastPj.IdPersonaje + 1;

            await _repo.AddPersonaje(personaje, token);

            return RedirectToAction("BySerie", "Personajes", new { @id = personaje.IdSerie });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int idpersonaje)
        {
            Personaje personaje = await _repo.GetPersonaje(idpersonaje);

            Serie serie = await _repo.GetSerie(personaje.IdSerie);
            ViewData["Serie"] = serie.Titulo;

            List<Serie> series = await _repo.GetSeries();
            var seriesDisplay = series.Select(x => new
            {
                Id = x.IdSerie,
                Value = x.Titulo
            }).OrderBy(x => x.Value)
            .ToList();

            var seriesList = new SelectList(seriesDisplay, "Id", "Value");
            ViewBag.Series = seriesList;

            return View(personaje);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Personaje personaje)
        {
            string token = HttpContext.Session.GetString("TOKEN");
            
            await _repo.UpdatePersonaje(personaje, token);

            return RedirectToAction("BySerie", "Personajes", new { @id = personaje.IdSerie });
        }
    }
}
