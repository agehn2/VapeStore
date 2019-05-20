using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VapeStore.Models;


namespace VapeStore.Controllers
{
    public class JuiceController : Controller
    {
        // GET: Juice/Random
        public ActionResult Random()
        {
            var juice = new Juice() {Brand = "Excision", Id = 1};
            return View(juice);
        }

        public ActionResult Edit(int Id)
        {
            return Content("id" + Id);
        }
        //// Juices
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
        public ActionResult ByReviewDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}