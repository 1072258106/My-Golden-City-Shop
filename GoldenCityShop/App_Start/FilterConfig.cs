using GoldenCityShop.Filters;
using System.Web;
using System.Web.Mvc;

namespace GoldenCityShop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
           // filters.Add(new ForceWww("http://localhost:34381/"));
            //customize elmah error handler for exceptions .this should be add befor HandleErrorAttribute 
            filters.Add(new ElmahHandledErrorLoggerFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
