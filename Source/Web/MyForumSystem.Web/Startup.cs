using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyForumSystem.Web.Startup))]
namespace MyForumSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
