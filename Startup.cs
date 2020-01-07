using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSIPortfolio.Startup))]
namespace MSIPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
