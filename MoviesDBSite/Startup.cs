using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesDBSite.Startup))]
namespace MoviesDBSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
