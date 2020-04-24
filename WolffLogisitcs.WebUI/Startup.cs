using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WolffLogisitcs.WebUI.Startup))]
namespace WolffLogisitcs.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
