using System;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace SimpleTranslator.Models.Translations;

public sealed class Translator : ITranslator
{
    private ILanguage sourceLanguage;
    // Private static instance of the Translator class
    private static readonly Lazy<Translator> instance = new Lazy<Translator>(() => new Translator());

    // Private constructor to prevent instantiation from outside
    private Translator()
    {
         sourceLanguage = new SourceLanguage(); 
    }

    // Public static property to access the single instance
    public static Translator Instance => instance.Value;

    // Example method for translation
    public string Translate(string sourceText, DestinationLanguage destinationLanguage)
    {
        // Simulate translation logic
        if (sourceText != "")
        {
            return $"Translated '{sourceText}' in '{sourceLanguage.Name}'('{sourceLanguage.ISOCode}') 'to {destinationLanguage.Name}'('{destinationLanguage.ISOCode}')";
        }
        else
            return "";
    }

    public Task<string> TranslateText(string text, string language)
    {
        throw new NotImplementedException();
    }

    public Task<string> TranslateHtml(string text, string language)
    {
        throw new NotImplementedException();
    }
}
