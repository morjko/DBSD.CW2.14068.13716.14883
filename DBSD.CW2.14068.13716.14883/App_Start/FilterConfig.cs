using System.Web;
using System.Web.Mvc;

namespace DBSD.CW2._14068._13716._14883
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
