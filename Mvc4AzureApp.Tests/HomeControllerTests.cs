using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvc4AzureApp;
using Mvc4AzureApp.Services;
using Mvc4AzureApp.Controllers;
using System.Web.Mvc;

namespace Mvc4AzureApp.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Add_Returns_Correct_Sum()
        {
            // Arrange
            var service = new CalculatorService();
            var controller = new HomeController(service);

            // Act
            var result = controller.Add(2, 3) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.ViewBag.Result);
        }
    }
}
