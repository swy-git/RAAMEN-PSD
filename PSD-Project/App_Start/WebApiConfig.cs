using System.Web.Http;
using System.Web.Routing;

namespace PSD_Project
{
    public static class WebApiConfig
    {
        public static void RegisterRoutes(this HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "API Default",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}