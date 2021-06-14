using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookList.Web.Startup))]
namespace BookList.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
