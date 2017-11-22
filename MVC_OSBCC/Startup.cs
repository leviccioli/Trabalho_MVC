using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_OSBCC.Startup))]
namespace MVC_OSBCC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
