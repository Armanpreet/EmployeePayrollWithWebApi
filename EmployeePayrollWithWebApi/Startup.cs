using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeePayrollWithWebApi.Startup))]
namespace EmployeePayrollWithWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
