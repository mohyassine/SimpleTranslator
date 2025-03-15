using System;

namespace SimpleTranslator.Models;

public class DestinationLanguage : ILanguage
{
    private string _isoCode = "fr-FR";
    private string _name = "French";
    public string ISOCode { get => _isoCode; set => _isoCode = value; }
    public string Name { get => _name; set => _name = value; }

}
