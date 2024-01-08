using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie0
{
    public class Elektronika : Produkt
    {
        public string Model;
        public int RokWydania;

        public Elektronika(string Model, int RokWydania)
        {
            this.Model = Model;
            this.RokWydania = RokWydania;
        }


        public override void WyświetlInfo()
        {
            base.WyświetlInfo();
            Console.WriteLine($"Model: {Model} \n Rok Wydania: {RokWydania}");
        }
    }
}
