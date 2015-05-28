using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nwd.mvc.Startup))]
namespace Nwd.mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
