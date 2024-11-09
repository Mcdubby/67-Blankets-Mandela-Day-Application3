using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_67_Blankets_Mandela_Day_Application3.Startup))]
namespace _67_Blankets_Mandela_Day_Application3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
