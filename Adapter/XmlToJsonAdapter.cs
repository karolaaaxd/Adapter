using System;

using System.Linq;

namespace Adapter.Classes
{
    class XmlToJsonAdapter
    {
        private readonly PlikConverter _plikConverter;

        public XmlToJsonAdapter(PlikConverter plikConverter)
        {
            _plikConverter = plikConverter;
        }

        public void ConvertXmlToJson()
        {
            var Producenci = _plikConverter.GetXML()
                    .Element("Producenci")
                    .Elements("Producent")
                    .Select(k => new Producent
                    {
                        Firma = k.Attribute("Firma").Value,
                        Nazwa = k.Attribute("Nazwa").Value,
                        Ilosc = Convert.ToInt32(k.Attribute("Ilosc").Value)
                    });

            new JsonConverter(Producenci)
                .ConvertToJson();
        }
    }
}
