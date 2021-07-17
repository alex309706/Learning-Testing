using Moq;
using ProjectToTest.Interfaces;
using Xunit;
using ProjectToTest.Controllers;
using System.Collections.Generic;
using ProjectToTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace xUnitTests_CodeGen_.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexReturnsAViewResultWithAListOfUsers()
        {
            var mock = new Mock<IRepository>();

            mock.Setup(repo=>repo.GetAll()).Returns(GetTestUsers());

            var controller = new HomeController(mock.Object);

            var result = controller.Index();

            var viewResult = Assert.IsAssignableFrom<ViewResult>(result);

            var model = Assert.IsAssignableFrom<IEnumerable<User>>(viewResult.Model);

            Assert.Equal(GetTestUsers().Count,model.Count());



        }
        private List<User> GetTestUsers()
        {
            var users = new List<User>
            {
                new User { Id=1, Name="Tom", Age=35},
                new User { Id=2, Name="Alice", Age=29},
                new User { Id=3, Name="Sam", Age=32},
                new User { Id=4, Name="Kate", Age=30}
            };
            return users;
        }
    }
}
