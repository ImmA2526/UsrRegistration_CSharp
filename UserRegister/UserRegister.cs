using System;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegisteration
{
   public class UserRegister
    {
        public static string Pattern = "^([A-Z]{1})+[a-zA-Z0-9]{2,}$";
        public bool FirstName(string First_Name)
        {
            Regex Fn = new Regex(Pattern);
            bool Validate = Fn.IsMatch(First_Name);
            return Validate;
        }
    }
}
