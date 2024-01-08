using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie0
{
    public class Ksiazka : Produkt
    {
        public string Autor { get; set; }
        public string Wydawnictwo { get; set; }

        public Ksiazka(string autor, string wydawnictwo)
        {
            this.Autor = autor;
            this.Wydawnictwo = wydawnictwo;
        }

        public override void WyświetlInfo()
        {
            base.WyświetlInfo();
            Console.WriteLine($"Autor: {Autor}\nWydawnictwo: {Wydawnictwo}");
        }
    }
}
