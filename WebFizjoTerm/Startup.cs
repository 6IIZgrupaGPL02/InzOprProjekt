using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFizjoTerm.Startup))]
namespace WebFizjoTerm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
