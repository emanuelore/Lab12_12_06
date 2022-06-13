using System.Web;
using System.Web.Mvc;

namespace MVCAJAX_DAEA_12
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
