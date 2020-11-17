using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IRPF_2021_fasec.Startup))]
namespace IRPF_2021_fasec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
