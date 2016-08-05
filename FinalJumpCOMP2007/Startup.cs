using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalJumpCOMP2007.Startup))]
namespace FinalJumpCOMP2007
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
