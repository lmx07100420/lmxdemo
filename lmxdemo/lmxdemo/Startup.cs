using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lmxdemo.Startup))]
namespace lmxdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
