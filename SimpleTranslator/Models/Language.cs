using System;

namespace SimpleTranslator.Models;

public interface ILanguage
{
    public string ISOCode { get; set; }
    public string Name { get; set; }  
}
