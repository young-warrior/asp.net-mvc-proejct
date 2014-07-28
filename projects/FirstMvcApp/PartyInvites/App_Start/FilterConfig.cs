using System.Web;
using System.Web.Mvc;

namespace PartyInvites
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Add comment
            filters.Add(new HandleErrorAttribute());
        }
    }
}