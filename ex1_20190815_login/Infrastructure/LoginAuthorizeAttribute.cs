using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex1_20190815_login.Infrastructure
{
    public class LoginAuthorizeAttribute: AuthorizeAttribute
    {
       //判斷他有沒有登陸成功
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //if (httpContext.Session["user"]== null)
            //{
            //    return false;
            //}
            //return true;
            
            return httpContext.Session["user"] != null;
        }
        
        //登陸成功轉頁
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult("/Login/Login");
        }
    }
}