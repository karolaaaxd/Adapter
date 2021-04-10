using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Adapter.Classes
{
    class JsonConverter
    {
        private IEnumerable<Producent> _producenci;

        public JsonConverter(IEnumerable<Producent> producenci)
        {
            _producenci = producenci;
        }

    

        public void ConvertToJson()
        {
            var jsonProducenci = JsonConvert.SerializeObject(_producenci, Newtonsoft.Json.Formatting.Indented);

            Console.WriteLine("\nWyswietlenie listy\n");
            Console.WriteLine(jsonProducenci);
        }
    }
}
