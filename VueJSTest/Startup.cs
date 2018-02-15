using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VueJSTest.Startup))]
namespace VueJSTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
