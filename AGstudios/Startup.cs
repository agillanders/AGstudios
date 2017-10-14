using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AGstudios.Startup))]
namespace AGstudios
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
