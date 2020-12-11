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
    }
}
