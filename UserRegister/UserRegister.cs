using System;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegisteration
{
    public class UserRegister
    {
        public static string Message = "Happy";
        public static string Pattern = "^([A-Z]{1})+[a-zA-Z0-9]{2,}$";
        public static string EmailID = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.,-]+$";
        public static string MobileNo = "^[0-9]{2}[ ][0-9]{10}$";
        public static string Pasword = "^(?=.*[A-Z])(?=.*[@.#$%*])[a - zA-Z0-9].{8,}$";

        public bool FirstName(string First_Name)
        {
            try
            {
                Regex Fn = new Regex(Pattern);
                bool Validate = Fn.IsMatch(First_Name);
                return Validate;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_FirstName, "Invalid Name Please Type Valid One");
            }
        }

        public bool LastName(string Last_Name)
        {
            try
            {
                Regex Ln = new Regex(Pattern);
                bool Validate = Ln.IsMatch(Last_Name);
                return Validate;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_LastName, "Invalid Name Please Type Valid One");
            }
        }
        public bool Email(string Emailid)
        {
            try
            {
                Regex Em = new Regex(EmailID);
                bool Validate = Em.IsMatch(Emailid);
                return Validate;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_EmailId, "Invalid Email Please Type Valid One");
            }
        }
        
        public bool MobileNumber(string Mobile)
        {
            try
            {
                Regex Mn = new Regex(MobileNo);
                bool Validate = Mn.IsMatch(Mobile);
                return Validate;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MobileNo, "Invalid Mobile No Please Type Valid One");
            }
        }

        public bool Password(string Pwd)
        {
            try
            {
                Regex Pw = new Regex(Pasword);
                bool Validate = Pw.IsMatch(Pwd);
                return Validate;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_Password, "Invalid Password Please Type Valid One");
            }
        }
        
        public bool MessageCheck(string Msg)
        {
            Regex Ms = new Regex(Message);
            bool Validate = Ms.IsMatch(Msg);
            return Validate;
        }
        /// <summary>
        /// Checks the multiple email with parameterised.
       
        public string CheckMultipleEmail(string mail)
        {
            UserRegister Mail = new UserRegister();
            bool MailEntry1 = Mail.Email(mail);
           
            if (MailEntry1.Equals(Mail))
                return "Entry is Succesfull";
            else
                return "Entry is Fail";
        }

        /// <summary>
        /// Using Lambda Expression
        /// </summary>
        public static Func<string, bool> ValidateUserDetailFirstName = First_Name => Regex.IsMatch(First_Name, Pattern);
        public static Func<string, bool> ValidateUserDetailLAstNAme = Last_Name => Regex.IsMatch(Last_Name, Pattern);
        public static Func<string, bool> ValidateEMail = Mail => Regex.IsMatch(Mail, EmailID);
        public static Func<string, bool> ValidateMobile = Mobile => Regex.IsMatch(Mobile, MobileNo);
        public static Func<string, bool> ValidatePassword = Pwd => Regex.IsMatch(Pwd, Pasword);
    }
}
