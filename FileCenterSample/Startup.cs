using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FileCenterSample.Startup))]
namespace FileCenterSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
