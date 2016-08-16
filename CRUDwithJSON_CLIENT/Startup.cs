using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDwithJSON_CLIENT.Startup))]
namespace CRUDwithJSON_CLIENT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
