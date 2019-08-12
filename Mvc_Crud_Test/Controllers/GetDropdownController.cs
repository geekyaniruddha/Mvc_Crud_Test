using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Crud_Test.Models;
namespace Mvc_Crud_Test.Controllers
{
    public class GetDropdownController : Controller
    {
        //
        // GET: /GetDropdown/
        OfficeEntities ob = new OfficeEntities();
        public ActionResult Index()
        {

            ViewBag.list = new SelectList(ob.TblCountry.ToList(), "Cid", "Cname");
            return View();
        }
        public JsonResult Getstate(string cide)
        {
            int cid = Convert.ToInt32(cide);
            var Q = (from test in ob.Tblstate where test.Cid == cid select test).ToList();
            return Json(Q, JsonRequestBehavior.AllowGet);
        }
    }
}
