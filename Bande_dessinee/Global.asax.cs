using System.Web.Mvc; // Assurez-vous que la référence d'assembly System.Web.Mvc est ajoutée
using System.Web.Routing;

namespace Bande_dessinee
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
