using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(deguchi01.Startup))]
namespace deguchi01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
