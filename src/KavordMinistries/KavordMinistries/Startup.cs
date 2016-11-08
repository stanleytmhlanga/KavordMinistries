using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KavordMinistries.Startup))]
namespace KavordMinistries
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
