using Microsoft.AspNetCore.Mvc;
using Moq;
using SimpleTranslator.Controllers;
using SimpleTranslator.Models;

namespace SimpleTranslator.Tests
{
    public class TranslationControllerTests
    {
        [Theory]
        [InlineData("Hello")]
        [InlineData("Good morning")]
        public async Task Translate_ReturnsViewResult_WithTranslatedText(string sourceText)
        {
            // Arrange
            var mockTranslator = new Mock<ITranslator>();
            mockTranslator.Setup(t => t.TranslateText(It.IsAny<string>(), It.IsAny<string>()))
                          .ReturnsAsync("Translated Text");

            var controller = new TranslationController();

            // Act
            var result = await controller.Translate(sourceText);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal("Bonjour", viewResult.ViewData["translatedText"]);
        }

        [Fact]
        public void Throw_ReturnsProblemResult()
        {
            // Arrange
            var controller = new TranslationController();

            // Act
            var result = controller.Throw();

            // Assert
            Assert.IsType<ObjectResult>(result);
        }
    }
}