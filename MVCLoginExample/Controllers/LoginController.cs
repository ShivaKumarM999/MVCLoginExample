using MVCLoginExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLoginExample.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }



        [HttpPost]
        public ActionResult Login(EmpLogin model)
        {
            if (model.UserName.Equals("Shiva") && model.Password.Equals("Rama"))
                return RedirectToAction("Index");
            else
            {
                ViewBag.ErrorMsg = "Invalid UserName & Password";
                return View();
            }
        }
    }
}