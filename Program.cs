using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie0;

class Program
{
    static void Main(string[] args)
    {
        Ksiazka książka = new Ksiazka("Adam Nowak", "Testowe Wydawnictwo");

        Elektronika elektronika = new Elektronika("Testowy Model", 2);

        Odziez odziez = new Odziez();
        odziez.Nazwa = "Nazwa";
        odziez.Opis = "testowy opis";
        odziez.Cena = 50;
        odziez.JestDostepny = true;
        odziez._Rozmiar = "M";

        Klient klient = new Klient();
        klient.Imie = "Jan";
        klient.Nazwisko = "Kowalski";

        klient.DodajDoKoszyka(książka);
        klient.DodajDoKoszyka(elektronika);
        klient.DodajDoKoszyka(odziez);

        foreach (var produkt in klient.Koszyk)
        {
            produkt.WyświetlInfo();
        }


        Console.WriteLine($"Cena książki: {klient.WyswietlCeneProduktu(książka)}");

        decimal cenaKoszyka = klient.ObliczKosztKoszyka();
        Console.WriteLine($"Całkowity koszt koszyka: {cenaKoszyka}");
    }
}
