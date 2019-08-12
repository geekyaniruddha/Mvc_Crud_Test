using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Crud_Test.Models;
namespace Mvc_Crud_Test.Controllers
{
    public class Update_DeleteController : Controller
    {
        //
        // GET: /Update_Delete/
        OfficeEntities obj = new OfficeEntities();
        public ActionResult Index()
        {
            ViewBag.list = obj.EmployeeDetails.ToList();
            return View();
        }
        public JsonResult GetUser(string Empide)
        {
            var Q = obj.EmployeeDetails.Where(M => M.empid == Empide).FirstOrDefault();
            return Json(Q, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Index(Homemodel ob)
        {
            var Q = obj.EmployeeDetails.Where(M => M.empid == ob.empdt.empid).FirstOrDefault();
            Q.Name = ob.empdt.Name;
            Q.Addr = ob.empdt.Addr;
            Q.Phno = ob.empdt.Phno;
            Q.Sal = ob.empdt.Sal;
            Q.City = ob.empdt.City;
            Q.Gen = ob.empdt.Gen;
            Q.Dep = ob.empdt.Dep;
            Q.Cmp = ob.empdt.Cmp;
            obj.SaveChanges();
            ViewBag.list = obj.EmployeeDetails.ToList();
            return View();
        }
        public JsonResult DeleteUser(string Ide)
        {
            var Q = obj.EmployeeDetails.Where(M => M.empid == Ide).FirstOrDefault();
            obj.EmployeeDetails.Remove(Q);
            obj.SaveChanges();
            return Json("Success", JsonRequestBehavior.AllowGet);
        }
    }
}
