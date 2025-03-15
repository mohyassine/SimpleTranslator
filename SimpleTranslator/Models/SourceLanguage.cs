using System;
using System.Reflection.Metadata.Ecma335;

namespace SimpleTranslator.Models;

public class SourceLanguage : ILanguage
{
    private string _isoCode = "en-EN";
    private string _name = "English";
    public string ISOCode { get => _isoCode; set => _isoCode = value; }
    public string Name { get => _name; set => _name = value; }
}
