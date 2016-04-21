using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheAccounting.Models.ViewModels;

namespace TheAccounting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var model = new List<FeeData> {
              new FeeData {Id=1, FeeType=enFeeType.支出, FeeDay=new DateTime(2016,1,1), Amount=300 },
              new FeeData {Id=2, FeeType=enFeeType.支出, FeeDay=new DateTime(2016,1,2), Amount=1600 },
              new FeeData {Id=3, FeeType=enFeeType.支出, FeeDay=new DateTime(2016,1,3), Amount=800 }
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}