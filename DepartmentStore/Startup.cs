using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DepartmentStore.Startup))]
namespace DepartmentStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
