using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie0
{
 public class Produkt : Produkt1
    {
        public string Nazwa;
        public string Opis;
        public decimal Cena;
        public bool JestDostepny;


        public virtual void WyświetlInfo()
        {
            Console.WriteLine($"Nazwa: {Nazwa}\nOpis: {Opis}\nCena: {Cena}\n");
            Console.WriteLine($"Dostępność: {(JestDostepny ? "Dostępny" : "Niedostępny")}");

        }

        public virtual decimal AktualnaCena()
        {
            return Cena;
        }

        public virtual int DostępnaIlosc()
        {
            return JestDostepny ? 1 : 0;
        }
    }
}
