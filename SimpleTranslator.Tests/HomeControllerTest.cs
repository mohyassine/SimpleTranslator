using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using SimpleTranslator.Controllers;
using Xunit;

namespace SimpleTranslator.Tests.Controllers;

public class HomeControllerTest
{
    private readonly Mock<ILogger<HomeController>> _mockLogger;
    private readonly HomeController _controller;

    public HomeControllerTest()
    {
        _mockLogger = new Mock<ILogger<HomeController>>();
        _controller = new HomeController(_mockLogger.Object);
    }

    [Fact]
    public void Check_ReturnsOkResult()
    {
        // Act
        var result = _controller.Check();

        // Assert
        Assert.IsType<OkObjectResult>(result);
        var okResult = result as OkObjectResult;
        Assert.NotNull(okResult);
        Assert.Equal("running", okResult.Value);
    }

    [Fact]
    public void Index_ReturnsViewResult()
    {
        // Act
        var result = _controller.Index();

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public void Error_ReturnsNotFoundResult()
    {
        // Act
        var result = _controller.Error();

        // Assert
        Assert.IsType<NotFoundObjectResult>(result);
        var notFoundResult = result as NotFoundObjectResult;
        Assert.NotNull(notFoundResult);
        Assert.Equal("Request Error!", notFoundResult.Value);
    }
}
