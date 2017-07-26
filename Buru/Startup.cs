using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Buru.Startup))]
namespace Buru
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
