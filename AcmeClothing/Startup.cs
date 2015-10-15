using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcmeClothing.Startup))]
namespace AcmeClothing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
