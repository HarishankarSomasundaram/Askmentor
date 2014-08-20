using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Askmentor.WebUI.Startup))]
namespace Askmentor.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
