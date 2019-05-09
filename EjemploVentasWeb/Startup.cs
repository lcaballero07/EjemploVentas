using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploVentasWeb.Startup))]
namespace EjemploVentasWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
