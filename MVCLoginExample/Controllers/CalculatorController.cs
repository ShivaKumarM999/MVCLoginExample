using MVCLoginExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLoginExample.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Add(Calculator cal)
        //{
        //    cal.Result = cal.Num1 + cal.Num2;
        //    return View(cal);
        //}

        //[HttpPost]
        //public ActionResult Add(Calculator cal, string Add, string Sub, string Mul, string Div)
        //{
        //    if(!string.IsNullOrEmpty(Add))
        //    cal.Result = cal.Num1 + cal.Num2;
        //    if (!string.IsNullOrEmpty(Sub))
        //        cal.Result = cal.Num1 - cal.Num2;
        //    if (!string.IsNullOrEmpty(Mul))
        //        cal.Result = cal.Num1 * cal.Num2;
        //    if (!string.IsNullOrEmpty(Div))
        //        cal.Result = cal.Num1 / cal.Num2;
        //    return View(cal);
        //}

        //[HttpPost]
        //public ActionResult Add(Calculator cal, string calsi)
        //{

        //    switch (calsi)
        //    {
        //        case "Add":
        //            cal.Result = cal.Num1 + cal.Num2;break;
        //        case "Sub":
        //            cal.Result = cal.Num1 - cal.Num2; break;
        //        case "Mul":
        //            cal.Result = cal.Num1 * cal.Num2; break;
        //        case "Div":
        //            cal.Result = cal.Num1 / cal.Num2; break;
        //    }
        //    return View(cal);
        //}
    }
}