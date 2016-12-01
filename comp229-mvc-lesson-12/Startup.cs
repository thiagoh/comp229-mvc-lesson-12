using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comp229_mvc_lesson_12.Startup))]
namespace comp229_mvc_lesson_12 {
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
