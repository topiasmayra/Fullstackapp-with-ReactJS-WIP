using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Sealgram.Controllers;
using Sealgram.Data;
using Sealgram.Models;
using System.Threading.Tasks;
using Xunit;

namespace Sealgram.Tests
{
    public class UsercontrollerTest
    {
        private Mock<SealgramDbContext> _mockContext;
        private UsersController _controller;

        public UsercontrollerTest()
        {
            _mockContext = new Mock<SealgramDbContext>();
            _controller = new UsersController(_mockContext.Object);
        }

        [Fact]
        public async Task GetUsers_ReturnsOkResult_WithListOfUsers()
        {
            // Arrange
            var users = new List<User>
            {
                new User { UserId = 1, Username = "John" },
                new User { UserId = 2, Username = "Jane" },
                new User { UserId = 3, Username = "Mike" }
            };
            var mockDbSet = new Mock<DbSet<User>>();
            mockDbSet.As<IQueryable<User>>().Setup(m => m.Provider).Returns(users.AsQueryable().Provider);
            mockDbSet.As<IQueryable<User>>().Setup(m => m.Expression).Returns(users.AsQueryable().Expression);
            mockDbSet.As<IQueryable<User>>().Setup(m => m.ElementType).Returns(users.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<User>>().Setup(m => m.GetEnumerator()).Returns(users.GetEnumerator());

            _mockContext.Setup(c => c.Users).Returns(mockDbSet.Object);

            // Act
            var result = await _controller.GetUsers();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsAssignableFrom<IEnumerable<User>>(okResult.Value);
            Assert.Equal(users.Count, model.Count());
        }

        // Add more tests for other action methods if needed
    }
}