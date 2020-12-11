using System;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegisteration
{
   public class UserRegister
    {
        public static string Pattern = "^([A-Z]{1})+[a-zA-Z0-9]{2,}$";
        public static string EmailID = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.,-]+$";
        public bool FirstName(string First_Name)
        {
            Regex Fn = new Regex(Pattern);
            bool Validate = Fn.IsMatch(First_Name);
            return Validate;
        }
        public bool LastName(string Last_Name)
        {
            Regex Ln = new Regex(Pattern);
            bool Validate = Ln.IsMatch(Last_Name);
            return Validate;
        }
        public bool Email(string Emailid)
        {
            Regex Em = new Regex(EmailID);
            bool Validate = Em.IsMatch(Emailid);
            return Validate;
        }

    }
}
