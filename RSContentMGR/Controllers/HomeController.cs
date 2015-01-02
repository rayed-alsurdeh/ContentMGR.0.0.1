using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RSContentMGR.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        RSContentMGR.Models.CMGRDataContext db = new Models.CMGRDataContext();
        public ActionResult Index()
        {
            // my comment goes here 
            var catgs = db.getCtgs();
            return View(catgs.ToList());
        }

    }
}
