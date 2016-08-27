using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingReflection.Startup))]
namespace TestingReflection
{
    public partial class Startup
    {
        //comment added
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
