using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RMIS.Startup))]
namespace RMIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
