using System;
using System.Runtime.CompilerServices;
using Google.Cloud.Translation.V2;

namespace SimpleTranslator.Models;

/**
 * Translator class:
 *  - implements the ITranslator interface
 *  - uses the Google Cloud Translation API to translate text
 *  - uses the Singleton pattern to ensure only one instance of the class is created
 */
public class Translator : ITranslator
{
    private readonly TranslationClient client;

    // Private static instance of the Translator class
    private static readonly Lazy<Translator> instance = new(() => new Translator());

    // Private constructor to prevent instantiation from outside
    private Translator()
    {
        client = TranslationClient.Create();
    }

    public static Translator Instance => instance.Value;

    // Implement the TranslateText method from the ITranslator interface (Polymorphism)
    public async Task<string> TranslateText(string text, string language)
    {
        var response = await client.TranslateTextAsync(text, language);
        return response.TranslatedText;
    }

    public Task<string> TranslateHtml(string text, string language)
    {
        throw new NotImplementedException();
    }
}

