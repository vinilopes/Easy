using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(easyCRUD.Startup))]
namespace easyCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
