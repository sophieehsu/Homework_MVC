using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TheAccounting.Models;
using TheAccounting.Models.ViewModels;

namespace TheAccounting.Controllers
{
    public class HomeController : Controller
    {
        FeeModels db = new FeeModels();
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FeeData model)
        {
            var data = new AccountBook()
            {
                Id = Guid.NewGuid(),
                Categoryyy = (int)model.FeeType,
                Amounttt = (int)model.Amount,
                Dateee = model.FeeDay,
                Remarkkk = model.Memo
            };

            db.AccountBook.Add(data);
            db.SaveChanges();

            return View();
        }

        [ChildActionOnly]
        public ActionResult List()
        {
            // 取出最新的10筆紀錄
            var myFeeData = from d in db.AccountBook.OrderByDescending(x => x.Dateee).Take(10).OrderBy(x => x.Dateee)
                            select new FeeData
                            {
                                FeeType = (enFeeType)d.Categoryyy,
                                Amount = d.Amounttt,
                                FeeDay = d.Dateee
                            };

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