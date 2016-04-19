using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MenuProj.Startup))]
namespace MenuProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
