using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bootstrap_Website.Startup))]
namespace Bootstrap_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
