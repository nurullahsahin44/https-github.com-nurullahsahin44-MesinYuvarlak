using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MesinYuvarlak.Startup))]
namespace MesinYuvarlak
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
