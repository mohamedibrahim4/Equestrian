using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EquestrianProject.Startup))]
namespace EquestrianProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
