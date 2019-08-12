using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Crud_Test.Models;
namespace Mvc_Crud_Test.Controllers
{
  
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        OfficeEntities obj = new OfficeEntities();
        public ActionResult Index()
        {
            return View();            
        }
        [HttpPost]
        public ActionResult Index(Homemodel ob)
        {
            try
            {
                obj.EmployeeDetails.Add(new EmployeeDetails { empid = ob.empdt.empid, Name = ob.empdt.Name, Addr = ob.empdt.Addr, Phno = ob.empdt.Phno, Sal = ob.empdt.Sal, City = ob.empdt.City, Gen = ob.empdt.Gen, Dep = ob.empdt.Dep, Cmp = ob.empdt.Cmp });
                obj.SaveChanges();
                ViewBag.msg = "Data Inert Successfull";
                ModelState.Clear();
            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            return View();
        }
    }
}
