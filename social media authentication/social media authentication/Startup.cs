using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(social_media_authentication.Startup))]
namespace social_media_authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
