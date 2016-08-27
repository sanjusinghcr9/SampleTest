using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingReflection.Startup))]
namespace TestingReflection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
