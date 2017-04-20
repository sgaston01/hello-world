using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDemo67.Startup))]
namespace WebDemo67
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
