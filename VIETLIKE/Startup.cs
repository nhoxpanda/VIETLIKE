using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VIETLIKE.Startup))]
namespace VIETLIKE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
