using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaParcial1.Startup))]
namespace PruebaParcial1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
