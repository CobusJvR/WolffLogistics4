using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WolffLogistics.Startup))]
namespace WolffLogistics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
