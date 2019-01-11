using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoEmailProject.Startup))]
namespace DemoEmailProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
