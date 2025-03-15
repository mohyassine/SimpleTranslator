using System;

namespace SimpleTranslator.Utility;

public class TextUtility
{
    public static string TrimText(string text)
    {
        return text.Trim();
    }   

    public static string RemoveSpecialCharacters(string text)
    {
        var array = text.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray();
        return new string(array);
    }

}
