using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Term.Startup))]
namespace Term
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
