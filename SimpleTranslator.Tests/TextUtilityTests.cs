using SimpleTranslator.Utility;
using Xunit;

namespace SimpleTranslator.Tests;
public class TextUtilityTests
{
    [Fact]
    public void TrimText_RemovesLeadingAndTrailingWhitespace()
    {
        // Arrange
        string input = "  Hello, world!  ";
        string expected = "Hello, world!";

        // Act
        string result = TextUtility.TrimText(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RemoveSpecialCharacters_RemovesNonAlphanumericCharacters()
    {
        // Arrange
        string input = "Hello, world! @2025";
        string expected = "Hello world 2025";

        // Act
        string result = TextUtility.RemoveSpecialCharacters(input);

        // Assert
        Assert.Equal(expected, result);
    }
}