using System.Web;
using System.Web.Mvc;

namespace FinalJumpCOMP2007
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
