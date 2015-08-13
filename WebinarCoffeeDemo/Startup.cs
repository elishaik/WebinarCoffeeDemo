using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebinarCoffeeDemo.Startup))]
namespace WebinarCoffeeDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
