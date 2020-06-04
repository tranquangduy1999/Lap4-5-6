using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranQuangDuy_lap456.Startup))]
namespace TranQuangDuy_lap456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
