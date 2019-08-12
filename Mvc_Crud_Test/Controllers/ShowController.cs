using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Crud_Test.Models;
namespace Mvc_Crud_Test.Controllers
{
    public class ShowController : Controller
    {
        //
        // GET: /Show/
        OfficeEntities obj = new OfficeEntities();
       
        public ActionResult Index()
        {
            ViewBag.list = obj.EmployeeDetails.ToList();
            return View();
        }

    }
}
