using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie0
{
    public class Odziez : Produkt
    {
        public string _Rozmiar;

        public override void WyświetlInfo()
        {
            base.WyświetlInfo();
            Console.WriteLine($"Rozmiar: {_Rozmiar}");
        }
    }
}
