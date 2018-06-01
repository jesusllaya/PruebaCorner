using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaCorner.Startup))]
namespace PruebaCorner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
