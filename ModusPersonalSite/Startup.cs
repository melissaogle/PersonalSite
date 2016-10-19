using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModusPersonalSite.Startup))]
namespace ModusPersonalSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
