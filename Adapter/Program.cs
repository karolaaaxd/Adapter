using Adapter.Classes;
using System;


namespace AdapterClass
{
   
        class Program
        {
            static void Main(string[] args)
            {
                var plikConverter = new PlikConverter();
                var adapter = new XmlToJsonAdapter(plikConverter);
                adapter.ConvertXmlToJson();
                Console.ReadKey();
            }
        }
    }
