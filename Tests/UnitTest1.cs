using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module3Lab.Controllers;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var homeController = new HomeController();
            var result = homeController.About();
            Assert.IsNotNull(result);
        }
    }
}
