using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(starwarsapi2Service.Startup))]

namespace starwarsapi2Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}