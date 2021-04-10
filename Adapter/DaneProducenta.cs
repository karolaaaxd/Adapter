using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    public static class DaneProducenta
    {
        public static List<Producent> GetData() =>
        new List<Producent>
        {
            new Producent { Firma = "Wedel", Nazwa = "Babeczka", Ilosc = 20 },
            new Producent { Firma = "Milka", Nazwa = "Ciasteczka", Ilosc = 100 },
            new Producent { Firma = "Delecta", Nazwa = "Sernik", Ilosc = 7 }
        
        };
    }
}
