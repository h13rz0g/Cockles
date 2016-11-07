using Cockles.Code;
using System.Web.Mvc;

namespace Cockles.Web
{
    public class HandlerLoginAttribute : AuthorizeAttribute
    {
        public bool Ignore = true;
        public HandlerLoginAttribute(bool ignore = true)
        {
            Ignore = ignore;
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (Ignore == false)
            {
                return;
            }
            if (OperatorProvider.Provider.GetCurrent() == null)
            {
                WebHelper.WriteCookie("Cockles_login_error", "overdue");
                filterContext.HttpContext.Response.Write("<script>top.location.href = '/Login/Index';</script>");
                return;
            }
        }
    }
}