using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Crud_Test.Models;
namespace Mvc_Crud_Test.Controllers
{
    public class SearchIDController : Controller
    {
        //
        // GET: /SearchID/
        OfficeEntities ob = new OfficeEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Ide)
        {
            var Q = ob.EmployeeDetails.Where(M => M.empid == Ide).ToList();
            if (Q.Count > 0)
            {
                ViewBag.list = Q;
            }
            else
            {
                ViewBag.msg = "No Data Found!!";
            }
            return View();
        }
    }
}
