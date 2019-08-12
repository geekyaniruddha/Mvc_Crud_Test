using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Crud_Test.Models;
namespace Mvc_Crud_Test.Controllers
{
    public class SaveDataController : Controller
    {
        //
        // GET: /SaveData/
        OfficeEntities obj = new OfficeEntities();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult SaveRegistration(string Empide, string Nm, string Addr, string Ph, string Sal, string City, string Gen, string Dept, string Cmp)
        {
            int salary = Convert.ToInt32(Sal);
            obj.EmployeeDetails.Add(new EmployeeDetails { empid=Empide,Name=Nm,Addr=Addr,Phno=Ph,Sal=salary,City=City,Gen=Gen,Dep=Dept,Cmp=Cmp});
            obj.SaveChanges();
            return Json("Success", JsonRequestBehavior.AllowGet);
        }

    }
}
