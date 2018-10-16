using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalDNDSheetProj.Startup))]
namespace FinalDNDSheetProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
