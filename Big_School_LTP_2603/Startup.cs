using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Big_School_LTP_2603.Startup))]
namespace Big_School_LTP_2603
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
