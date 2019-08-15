using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ex1_20190815_login.Dll;
using ex1_20190815_login.Infrastructure.Attribute;
using ex1_20190815_login.Models;

namespace ex1_20190815_login.Controllers
{
    
    public class LoginController : Controller
    {
        // GET: Login
        
        public ActionResult Login()
        {
            this.Session["captial"] = DateTime.Now.ToString("HHmm");
            return this.View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {          
            //檢核Model是否有洞悉
            if (!this.ModelState.IsValid)
            {
                return this.View(loginViewModel);
            }

            //判斷是否登陸
            LoginService loginService = new LoginService();
            var isLogin = loginService.LoginVer(loginViewModel);
            
            if (!isLogin)
            {
                ViewBag.Message = "登錄錯誤";
                this.ModelState.AddModelError("LoginError", "登入失敗");
                return View(loginViewModel);
            }
            //登陸後轉頁
            else
            {                
                ViewBag.Message = "登錄成功";
                return Redirect("/Home/Index");
            }
            



        }
    }
}