using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie0
{
    public class Klient : Osoba
    {
        public List<Produkt1> Koszyk;

        public Klient()
        {
            Koszyk = new List<Produkt1>();
        }

        public void DodajDoKoszyka(Produkt1 Produkt1)
        {
            if (Produkt1.DostępnaIlosc() > 0)
            {
                Koszyk.Add(Produkt1);
            }
            else
            {
                Console.WriteLine("Produkt1 nie jest dostępny.");
            }
        }

        public decimal WyswietlCeneProduktu(Produkt1 Produkt1)
        {
            return Produkt1.AktualnaCena();
        }

        public decimal ObliczKosztKoszyka()
        {
            decimal koszt = 0;
            foreach (var Produkt1 in Koszyk)
            {
                koszt += Produkt1.AktualnaCena();
            }
            return koszt;
        }
    }
}
