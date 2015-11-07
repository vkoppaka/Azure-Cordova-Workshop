using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(starwarsapiService.Startup))]

namespace starwarsapiService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}