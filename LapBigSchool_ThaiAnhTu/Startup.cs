using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LapBigSchool_ThaiAnhTu.Startup))]
namespace LapBigSchool_ThaiAnhTu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
