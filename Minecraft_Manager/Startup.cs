using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Minecraft_Manager.Startup))]
namespace Minecraft_Manager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
