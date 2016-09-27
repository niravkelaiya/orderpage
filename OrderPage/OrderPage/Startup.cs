using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrderPage.Startup))]
namespace OrderPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
