using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ripoff_Of_Kenov.Startup))]
namespace Ripoff_Of_Kenov
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
