using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityFrameworkLearning.Startup))]
namespace EntityFrameworkLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
