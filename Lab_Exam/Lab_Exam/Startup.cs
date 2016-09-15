using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_Exam.Startup))]
namespace Lab_Exam
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
