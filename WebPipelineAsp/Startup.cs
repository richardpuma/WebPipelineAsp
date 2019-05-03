using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPipelineAsp.Startup))]
namespace WebPipelineAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
