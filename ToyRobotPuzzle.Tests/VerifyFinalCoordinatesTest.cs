using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.Web.Controllers;
using System.Web.Mvc;
using Robot.Model;
using System.Collections.Generic;

namespace ToyRobotPuzzle.Tests
{
    [TestClass]
    public class VerifyFinalCoordinatesTest
    {
        [TestMethod]
        public void IsFinalCoorinatesareValid()
        {
            HomeController homeController = new HomeController();
            List<ToyRobotOutputModel> finalCoordinates = new List<ToyRobotOutputModel>();
            var result = homeController.Index("PLACE 0, 0, NORTH\r\nMOVE\r\nREPORT") as ViewResult;
            var output = (ToyRobotOutputViewModel)result.ViewData.Model;
            foreach(var coordinates in output.ToyRobotOutputs)
            {
                Assert.AreEqual(coordinates.PositionX, 0);
                Assert.AreEqual(coordinates.PositionY, 1);
                Assert.AreEqual(coordinates.Heading, "NORTH");
            }
            
        }
    }
}
