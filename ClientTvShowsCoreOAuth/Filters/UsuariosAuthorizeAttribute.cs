using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace ClientTvShowsCoreOAuth.Filters
{
    public class UsuariosAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Solo queremos saber si el Usuario se ha validado o no
            // Cuando esté validado lo enviamos al Login
            var user = context.HttpContext.User;
            if (user.Identity.IsAuthenticated == false)
            {
                RouteValueDictionary ruta = new RouteValueDictionary(new
                {
                    controller = "Manage",
                    action = "Login"
                });
                RedirectToRouteResult result = new RedirectToRouteResult(ruta);
                context.Result = result;
            }
        }
    }
}
