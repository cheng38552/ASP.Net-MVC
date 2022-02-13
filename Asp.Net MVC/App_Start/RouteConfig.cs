using System.Web.Mvc;
using System.Web.Routing;

namespace Asp.Net_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Handle the Route of the axd request file.
            //E.g. ASP.Net Tracing
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Handle the Route called "Default".
            //The mapping URL is "{controller}/{]action}/{id}"
            //Set the default value of Controller, action, and id.
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

/*
1.
//routes.MapRoute(
//      name: "Default",
//      url: "{controller}/{action}/{id}",
//      defaults: new { controller = "Home", action= "Index", id = UrlParameter.Optional }
//);
1-1.
When a request comes in,
it's trying to do a pattern match based on
all the templates it sees in these mapped routes.
A route is some instrucions for
how to take a URI coming into a request
and map it to some code,
normally a controller.
In this case,
look at defaults parameter,
when user request Http://localhost:PortNumber/
IIS Express will run
HomeController Index action.
It will map to Controllers/HomeController.cs
and map to Index Method
1-2.
By convention in MVC.
All controllers will have Controller suffix.
This suffix is not requiredd in the URL.
So, if you want to invoke Home controller,
you specify /Home and not /HomeController.
*/
