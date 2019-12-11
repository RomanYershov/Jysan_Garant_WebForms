using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jysan_WebForms.Startup))]
namespace Jysan_WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
