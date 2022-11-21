/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp1.Tests
{
    internal class HomeControllerTests
    {
    }
}*/

using Microsoft.AspNetCore.Mvc;
//using UnitTestApp.Controllers;
using Xunit;

namespace UnitTestApp.Tests {
    public class HomeControllerTests {
        [Fact]
        public void IndexViewDataMessage() {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.Equal("Hello world!", result?.ViewData["Message"]);
        }

        [Fact]
        public void IndexViewResultNotNull() {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void IndexViewNameEqualIndex() {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.Equal("Index", result?.ViewName);
        }
    }
}

/*[Fact]
public void IndexTest() {
    // Arrange
    HomeController controller = new HomeController();
 
    // Act
    ViewResult result = controller.Index() as ViewResult;
 
    // Assert
    Assert.Equal("Hello world!", result?.ViewData["Message"]);
    Assert.NotNull(result);
    Assert.Equal("Index", result?.ViewName);
}*/