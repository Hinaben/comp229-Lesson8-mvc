using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comp229_Lesson8_mvc.Startup))]
namespace comp229_Lesson8_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
