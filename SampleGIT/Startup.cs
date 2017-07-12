using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleGIT.Startup))]
namespace SampleGIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
