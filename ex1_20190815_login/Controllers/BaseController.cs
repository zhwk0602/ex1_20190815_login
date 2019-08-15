using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ex1_20190815_login.Infrastructure;

namespace ex1_20190815_login.Controllers
{
    [LoginAuthorize]
    public class BaseController : Controller
    {
      
    }
}