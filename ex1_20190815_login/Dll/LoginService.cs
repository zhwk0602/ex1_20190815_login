using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ex1_20190815_login.Models;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace ex1_20190815_login.Dll
{
    public class LoginService
    {
        private NorthwindEntities DB=  new NorthwindEntities();

        public string Md5Encode(string password)
        {
            
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password.ToString()));
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));

            }
            var ispassword = strBuilder.ToString();
            return strBuilder.ToString();

        }
        public bool LoginVer(LoginViewModel loginViewModel  )
        {
            var passwordEncode = Md5Encode(loginViewModel.Password);
            var user = DB.AspNetUsers.Where(x => x.Email.ToString() == loginViewModel.Account.ToString() 
            &&  x.PasswordHash.ToString() == passwordEncode).FirstOrDefault();

            if (user == null) {
                return false;
            }
            else {
                HttpContext.Current.Session["user"] = user;
                return true;
            }
            



        }
        
    }
}