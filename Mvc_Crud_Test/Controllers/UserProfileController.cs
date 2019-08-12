using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Crud_Test.Models;
namespace Mvc_Crud_Test.Controllers
{
    public class UserProfileController : Controller
    {
        //
        // GET: /UserProfile/
        OfficeEntities ob = new OfficeEntities();
        public ActionResult Index()
        {
            if (Session.IsNewSession)
            {
                return RedirectToAction("Index", "UserLogin");
            }
            else
            {
                ViewBag.list = Session["ID"].ToString();
            }
            return View();
        }
        public JsonResult ShowUserDetails()
        {
            string ide = Session["ID"].ToString();
            var Q = (from test in ob.Registration where test.Mailid == ide select test).FirstOrDefault();
            return Json(Q, JsonRequestBehavior.AllowGet);
        }
        public JsonResult UpdateUserDetails(string Mailid, string Nm, string Adr, string Ph, string Pin, string City, string Gen)
        {
            var Q = ob.Registration.Where(M => M.Mailid == Mailid).FirstOrDefault();
            Q.Name = Nm;
            Q.Adr = Adr;
            Q.Phno = Ph;
            Q.Pin = Pin;
            Q.City = City;
            Q.Gen = Gen;
            ob.SaveChanges();
            return Json("Success", JsonRequestBehavior.AllowGet);
        }
    }
}
