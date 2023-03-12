using System;
using System.Web;
using System.Web.Http;

namespace PSD_Project
{
    public class RaamenApp : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e) 
        {
            var config = GlobalConfiguration.Configuration;
            config.RegisterRoutes();
            config.EnsureInitialized();
        }
    }
}