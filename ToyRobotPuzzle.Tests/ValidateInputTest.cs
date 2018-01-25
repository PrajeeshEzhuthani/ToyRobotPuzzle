using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.Web.Controllers;

namespace ToyRobotPuzzle.Tests
{
    [TestClass]
    public class ValidateInputTest
    {
        [TestMethod]
        public void IsInputcommandsValid()
        {
            HomeController homeController = new HomeController();
           string vaidationMessage = homeController.ValidateInput("PLACE 0, 0, NORTH\r\nMOVE\r\nREPORT");
            Assert.AreEqual(vaidationMessage, string.Empty);
        }
    }
}
