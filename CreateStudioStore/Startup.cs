using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreateStudioStore.Startup))]
namespace CreateStudioStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
