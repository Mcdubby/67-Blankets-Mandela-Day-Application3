using System.Web;
using System.Web.Mvc;

namespace _67_Blankets_Mandela_Day_Application3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
