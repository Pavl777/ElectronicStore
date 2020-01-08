using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectronicStore.Startup))]
namespace ElectronicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
