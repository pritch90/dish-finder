using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DishFinder.Web.Startup))]
namespace DishFinder.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
