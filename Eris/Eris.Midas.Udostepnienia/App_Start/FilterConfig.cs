using System.Web;
using System.Web.Mvc;

namespace Eris.Midas.Udostepnienia
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
