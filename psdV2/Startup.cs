using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(psdV2.Startup))]
namespace psdV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
