using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Projeto01.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Projeto01.DAL.IndentityDbContextAplicacao;

namespace Projeto01.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<IdentityDbContextAplicacao>(IdentityDbContextAplicacao.Create);
            app.CreatePerOwinContext<GerenciadorUsuario>(GerenciadorUsuario.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Seguranca/Account/Login"),
            });
        }
    }
}