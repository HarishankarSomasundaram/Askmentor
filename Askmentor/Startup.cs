using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Askmentor.Startup))]
namespace Askmentor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
