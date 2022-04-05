using System.Xml.Linq;

namespace Library
{
    public static class NotFailingLocalNameTranslator
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
                _ => LocalName.Other,
            };
        }
    }
}