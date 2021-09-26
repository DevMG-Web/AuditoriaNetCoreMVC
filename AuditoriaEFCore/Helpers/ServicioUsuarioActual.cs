using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditoriaEFCore.Helpers
{
    public class ServicioUsuarioActual : IServicioUsuarioActual
    {
        private readonly IHttpContextAccessor httpContextAccesor;

        public ServicioUsuarioActual(IHttpContextAccessor httpContextAccesor)
        {
            this.httpContextAccesor = httpContextAccesor ?? throw new ArgumentException();
        }

        public string ObtenerNombreUsuarioActual()
        {
            return this.httpContextAccesor.HttpContext.User.Identity.Name;
        }
    }
}
