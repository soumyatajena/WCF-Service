using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalECFClientDemo.Startup))]
namespace FinalECFClientDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
