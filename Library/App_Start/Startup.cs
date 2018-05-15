﻿using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Library.BLL.Interfaces;
using Library.BLL.DTO;
using Library.BLL.Infrastructure;
using Library.BLL.Servises;
using System.Configuration;

[assembly: OwinStartup(typeof(Library.WEB.Models.App_Start.Startup))]
namespace Library.WEB.Models.App_Start
{
        public class Startup
        {
            IServiceCreator serviceCreator = new ServiceCreator();
            public void Configuration(IAppBuilder app)
            {
                app.CreatePerOwinContext<IUserService>(CreateUserService);
                app.UseCookieAuthentication(new CookieAuthenticationOptions
                {
                    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                    LoginPath = new PathString("/Account/Login"),
                });
            }

            private IUserService CreateUserService()
            {
                return serviceCreator.CreateUserService(ConfigurationManager.ConnectionStrings["LibraryContext"].ConnectionString);
            }
        }
}
