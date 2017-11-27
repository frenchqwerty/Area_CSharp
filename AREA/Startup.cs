using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AREA.Startup))]
namespace AREA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
