using System.Web;
using System.Web.Mvc;

namespace Big_School_LTP_2603
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
