using System;
using System.Linq;
using System.Xml.Linq;

namespace Adapter.Classes
{
    class PlikConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Producenci");
            var xAttributes = DaneProducenta.GetData()
                .Select(k => new XElement("Producent",
                                    new XAttribute("Nazwa", k.Nazwa),
                                    new XAttribute("Firma", k.Firma),
                                    new XAttribute("Ilosc", k.Ilosc)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}
