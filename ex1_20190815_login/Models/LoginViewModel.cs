using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ex1_20190815_login.Infrastructure.Attribute;

namespace ex1_20190815_login.Models
{
    
    public class LoginViewModel
    {
        [Required(ErrorMessage ="請輸入帳號")]
        [Display(Name ="帳號")]
        public string Account { get; set; }
        [Required(ErrorMessage = "請輸入密碼")]
        [Display(Name = "密碼")]
        
        public string Password{ get; set; }

        [Display(Name = "驗證碼")]
        [Required(ErrorMessage = "請輸入驗證碼")]
        [CustomerValidation(ErrorMessage = "驗證碼錯誤")]
        public string Captial { get; set; }
    }
}