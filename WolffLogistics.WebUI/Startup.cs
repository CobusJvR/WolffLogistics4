using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WolffLogistics.WebUI.Startup))]
namespace WolffLogistics.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
