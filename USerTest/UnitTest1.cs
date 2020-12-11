using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegisteration;
namespace USerTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly UserRegister Usr;
       
        public  UnitTest1()
        {
             Usr = new UserRegister();   
        }
        [TestMethod]
        public void FirstName_Test()
        {
            var Result = Usr.FirstName("Imran");
            Assert.AreEqual(true, Result);
        }
        [TestMethod]
        public void LastName_Test()
        {
            var Result = Usr.LastName("Imran");
            Assert.AreEqual(true, Result);
        }
        [TestMethod]
        public void Email_Test()
        {
            var Result = Usr.Email("imraninfo.1996@gmail.com");
            Assert.AreEqual(true, Result);
        }
        [TestMethod]
        public void Mobile_Test()
        {
            var Result = Usr.MobileNumber("91 9236789098");
            Assert.AreEqual(true, Result);
        }
        [TestMethod]
        public void Password_Test()
        {
            var Result = Usr.Password("Qwertyuiq1*");
            Assert.AreEqual(true, Result);

        }
    }
}
