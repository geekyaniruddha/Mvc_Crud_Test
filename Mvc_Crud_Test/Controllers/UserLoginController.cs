using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Crud_Test.Models;
namespace Mvc_Crud_Test.Controllers
{
    public class UserLoginController : Controller
    {
        //
        // GET: /UserLogin/
        OfficeEntities ob = new OfficeEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Mailide, string Pwd)
        {
            var Q = ob.Registration.Where(M => M.Mailid == Mailide && M.Pwd == Pwd).FirstOrDefault();
            if (Q != null)
            {
                Session["ID"] = Q.Mailid;
                return RedirectToAction("Index", "UserProfile");
            }
            else
            {
                ViewBag.msg = "Enter Correct MailID Or Password!!";
            }
            return View();
        }
        public ActionResult logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "UserLogin");
        }
    }
}
