using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewRelicSDKSample.Startup))]
namespace NewRelicSDKSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
