using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegisteration;
namespace USerTest
{
    [TestClass]
    public class UnitTest1
    {
        UserRegister Check = new UserRegister();
        private readonly UserRegister User;
        public  UnitTest1()
        {
             User = new UserRegister();   
        }

        [TestMethod]
        public void FirstName_Test()
        {
            var Result = User.FirstName("Imran");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void LastName_Test()
        {
            var Result = User.LastName("Imran");
            Assert.AreEqual(true, Result);
        }

        /// <summary>
        /// Emails the test.
        /// </summary>
        [TestMethod]
        public void Email_Test()
        {
            var Result = User.Email("imraninfo.1996@gmail.com");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void Mobile_Test()
        {
            var Result = User.MobileNumber("91 9236789098");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void Password_Test()
        {
            var Result = User.Password("Qwertyuiq1*");
            Assert.AreEqual(true, Result);

        }

        [TestMethod]
        public void Happy_Test()
        {
            var Result = User.MessageCheck("Happy");
            Assert.AreEqual(true,Result);
        }
        

        [TestMethod]
        [DataRow("imraninfo.1996@gmail.com")]
        [DataRow("nijamsayyad123@gmail.com")]
        public void MultipleMail(string mail)
        {
            UserRegister Mail = new UserRegister();
            var Result = Mail.CheckMultipleEmail(mail);
            Assert.AreEqual(Result, "Entry is Succesfull");
        }

        [TestMethod]
        [DataRow("imran")]
        public void InvalidName_TrowException(string FirstName)
        {
            try
            {
                Check.FirstName(FirstName);
            }
            catch (CustomException Exception)
            {
                Assert.AreEqual("Invalid First Name",Exception.Message);
            }
        }
        [TestMethod]
        [DataRow("shaikh")]
        public  void InvalidLastName_TrowException(string LastName)
        {
            try
            {
                Check.LastName(LastName);
            }
            catch (CustomException Exception)
            {
                Assert.AreEqual("Invalid LastName", Exception.Message);
            }
        }
        [TestMethod]
        [DataRow("imraninfo@gmail.com")]
        public void InvalidEmail_ThrowException(string Email)
        {
            try
            {
                Check.Email(Email);
            }
            catch (CustomException Exception)
            {
                Assert.AreEqual("Invalid Email",Exception.Message);
            }
        }
        [TestMethod]
        [DataRow("91 123456766")]
        public void InvalidMobileNo_TrowException(string MobileNo)
        {
            try
            {
                Check.MobileNumber(MobileNo);
            }
            catch (CustomException Exception)
            {
                Assert.AreEqual("Invalid Mobile No", Exception.Message);
            }
        }
        [TestMethod]
        [DataRow("12Q35abcd")]
        public void InvalidPassword_TrhowException(string Password)
        {
            try
            {
                Check.Password(Password);
            }
            catch (CustomException Exception)
            {
                Assert.AreEqual("Invalid Password",Exception.Message);
            }
        }

        /// <summary>
        /// Firsts the name using lambda expression.
        /// </summary>
        [TestMethod]
        public void FirstNameUsingLambdaExpression()
        {
            var Result = User.FirstName("Imran");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void LastNAmeUsingLambdaExpression()
        {
            var Result = User.LastName("Shaikh");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void EmailUsingLambdaExpression()
        {
            var Result = User.Email("imraninfo.1996@gmail.com");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void MobileNumberUsingLabdaExpression()
        {
            var Result = User.MobileNumber("91 9175833272");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void PasswordUingLambdaExpression()
        {
            var Result = User.Password("Qwerty@123");
            Assert.AreEqual(true, Result);
        }
    }
}
