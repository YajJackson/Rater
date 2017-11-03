using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoRater.Startup))]
namespace DemoRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
