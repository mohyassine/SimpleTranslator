using Google.Cloud.Language.V1;
using System;

namespace SimpleTranslator;
public class GoogleTranslator
{
    public void AnalyzeSentiment(string apiKey)
    {
        LanguageServiceClient client = new LanguageServiceClientBuilder
        {
            ApiKey = apiKey
        }.Build();

        string text = "Hello, world!";

        AnalyzeSentimentResponse response = client.AnalyzeSentiment(Document.FromPlainText(text));
        Console.WriteLine($"Text: {text}");
        Sentiment sentiment = response.DocumentSentiment;
        Console.WriteLine($"Sentiment: {sentiment.Score}, {sentiment.Magnitude}");
        Console.WriteLine("Successfully authenticated using the API key");
    }
}

