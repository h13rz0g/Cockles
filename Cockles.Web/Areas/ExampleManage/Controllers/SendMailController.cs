
using Cockles.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cockles.Web.Areas.ExampleManage.Controllers
{
    public class SendMailController : ControllerBase
    {
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SendMail(string account, string title, string content)
        {
            MailHelper mail = new MailHelper();
            mail.MailServer = Configs.GetValue("MailHost");
            mail.MailUserName = Configs.GetValue("MailUserName");
            mail.MailPassword = Configs.GetValue("MailPassword");
            mail.MailName = "Cockles";
            mail.Send(account, title, content);
            return Success("发送成功。");
        }
    }
}
