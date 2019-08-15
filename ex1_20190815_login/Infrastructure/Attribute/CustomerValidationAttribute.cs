using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ex1_20190815_login.Infrastructure.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomerValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var x = System.Web.HttpContext.Current.Session["captial"].ToString();
            if (value == null)
            {
                return false;
            }
           
            else if ( x!= value.ToString() )
            {
                return false;
            }
            
            return true;
        }
    }
}