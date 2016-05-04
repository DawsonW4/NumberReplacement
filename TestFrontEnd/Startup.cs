using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestFrontEnd.Startup))]
namespace TestFrontEnd
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
