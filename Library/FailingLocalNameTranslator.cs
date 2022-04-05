using System.Xml.Linq;

namespace Library
{
    public static class FailingLocalNameTranslator
    {
        public static LocalName GetElementType(XElement element)
        {
            var localName = element.Name.LocalName;
            return localName switch
            {
                "one" => LocalName.First,
                "two" => LocalName.Second,
                "three" => LocalName.Third,
                "four" => LocalName.Fourth,
                "five" => LocalName.Fifth,
                "six" => LocalName.Sixth,
                "seven" => LocalName.Seventh,
                _ => LocalName.Other,
            };
        }
    }
}