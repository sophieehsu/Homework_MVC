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
        public static List<FeeData> myFeeData { get; set; }

        public ActionResult Index()
        {
            myFeeData = new List<FeeData> {
              new FeeData {Id=1, FeeType=enFeeType.支出, FeeDay=new DateTime(2016,1,1), Amount=300 },
              new FeeData {Id=2, FeeType=enFeeType.支出, FeeDay=new DateTime(2016,1,2), Amount=1600 },
              new FeeData {Id=3, FeeType=enFeeType.支出, FeeDay=new DateTime(2016,1,3), Amount=800 }
            };

            return View();
        }

        [HttpPost]
        public ActionResult Index(FeeData model)
        {
            model.Id = myFeeData.Max(x => x.Id) + 1;
            myFeeData.Add(model);

            return View();
        }

        [ChildActionOnly]
        public ActionResult List()
        {
            return View(myFeeData);
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