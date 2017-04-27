using System.Web;
using System.Web.Mvc;

namespace Ripoff_Of_Kenov
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
