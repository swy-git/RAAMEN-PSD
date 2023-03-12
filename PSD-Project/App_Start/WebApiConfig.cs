using System.Web.Http;
using System.Web.Routing;

namespace PSD_Project
{
    public static class WebApiConfig
    {
        public static void RegisterRoutes(this HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
        }
    }
}