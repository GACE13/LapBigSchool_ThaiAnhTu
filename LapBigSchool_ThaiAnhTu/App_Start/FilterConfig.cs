using System.Web;
using System.Web.Mvc;

namespace LapBigSchool_ThaiAnhTu
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
