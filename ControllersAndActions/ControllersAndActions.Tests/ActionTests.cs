using System.Web.Mvc;
using ControllersAndActions.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void ControllerTest()
        {
            // Arrange the controller
            ExampleController target = new ExampleController();

            // Act - call the action method
            RedirectToRouteResult result = target.RedirectToRoute();

            // Assert - check the result
            Assert.IsFalse(result.Permanent);
            Assert.AreEqual("Example", result.RouteValues["controller"]);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("MyID", result.RouteValues["ID"]);
        }
    }
}
