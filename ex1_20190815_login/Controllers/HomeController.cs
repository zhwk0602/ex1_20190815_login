using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ex1_20190815_login.Infrastructure;


namespace ex1_20190815_login.Controllers
{
    // [LoginAuthorize]
    public class HomeController : BaseController
    {
        
        public ActionResult Index()

        {
            //擋登入 最簡單
            //if (this.Session["user"] == null)
            //{
            //    return this.Redirect("/Login/Login");
            //}
            return View();
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