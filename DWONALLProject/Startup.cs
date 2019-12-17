using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DWONALLProject.Startup))]
namespace DWONALLProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
