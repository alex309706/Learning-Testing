using Microsoft.AspNetCore.Mvc;
using Xunit;
using xUnitTesting.Controllers;
namespace UnitTests.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexMessageTesting()
        {
            //arrange
            HomeController homeController = new HomeController();
            //act
            ViewResult result = homeController.Index() as ViewResult;
            //assert
            Assert.Equal("Hello!",result?.ViewData["Message"]);

        }
        [Fact]
        public void ViewResultNotNull()
        {
            HomeController homeController = new HomeController();

            ViewResult result = homeController.Index() as ViewResult;

            Assert.NotNull(result);
        }
        [Fact]
        public void IndexViewNameEqualsIndex()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.Equal("Index",result?.ViewName);
        }

    }
}
