using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelWebApplication.Startup))]
namespace HotelWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
