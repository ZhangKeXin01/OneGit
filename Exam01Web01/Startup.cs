using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exam01Web01.Startup))]
namespace Exam01Web01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
