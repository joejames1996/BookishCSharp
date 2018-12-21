using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookishCSharp.Web.Startup))]
namespace BookishCSharp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
