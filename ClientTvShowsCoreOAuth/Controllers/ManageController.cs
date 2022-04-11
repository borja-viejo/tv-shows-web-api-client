using ClientTvShowsCoreOAuth.Models;
using ClientTvShowsCoreOAuth.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ClientTvShowsCoreOAuth.Controllers
{
    public class ManageController : Controller
    {
        private readonly ApplicationRepository _repo;
        public ManageController(ApplicationRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Usuarios");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            // Para validar usuarios, utilizo el Token; si el Token es null, las credenciales son incorrectas
            string token = await _repo.GetToken(userName, password);
            if (token == null)
            {
                ViewData["MENSAJE"] = "Usuario o Contraseña no son correctos";

                return View();
            }
            else
            {
                Usuario usuario = await _repo.PerfilUsuario(token);

                // Habilitar la seguridad de MVC con Claims
                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme,
                                                             ClaimTypes.Name,
                                                             ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, usuario.Password));
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, usuario.Email));
                identity.AddClaim(new Claim(ClaimTypes.Role, "Viewer"));

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                        principal,
                        new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTime.Now.AddMinutes(60)
                        });

                // Almacenar el Token una vez que el usuario ya existe
                HttpContext.Session.SetString("TOKEN", token);

                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            if (HttpContext.Session.GetString("TOKEN") != null)
            {
                //HttpContext.Session.SetString("TOKEN", String.Empty);
                HttpContext.Session.Remove("TOKEN");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
