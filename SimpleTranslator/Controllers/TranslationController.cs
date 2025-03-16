using Microsoft.AspNetCore.Mvc;
using SimpleTranslator.Models;
using SimpleTranslator.Utility;

namespace SimpleTranslator.Controllers;

public class TranslationController : Controller
{
    public TranslationController()
    {

    }

    public async Task<IActionResult> Translate(string sourceText)
    {
        try
        {
            DestinationLanguage destinationLanguage = new();
            ITranslator translator = Translator.Instance;

            if (sourceText != null)
            {
                var trimmedText = TextUtility.TrimText(sourceText);
                // Call the Translate method from the Translator class
                var result = await translator.TranslateText(trimmedText, destinationLanguage.ISOCode);
                System.Console.WriteLine($"Translation in {destinationLanguage.Name}: {result}");
                // Set the translated text in the ViewData dictionary
                ViewData["translatedText"] = result;
            }
            return View();
        }
        catch (Exception ex)
        {
            // Log the exception (you can use any logging framework)
            System.Console.WriteLine($"An error occurred: {ex.Message}");
            // Return an error view or a specific error message
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while translating the text.\n"+ex.Message);
        }
    }

    [HttpGet("Throw")]
    public IActionResult Throw()
    {
        return Problem();
    }

}
