using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_06_24
{
    internal class ContoCorrente
    {
        public double Saldo { get; set; }
        public bool ContoAperto { get; set; }

        public void ApriConto(double importo)
        {
            if(ContoAperto)
            {
                Console.WriteLine("Il conto è già aperto");
                return;
            }
            if(importo < 1000) {
                   Console.WriteLine("L'importo minimo per aprire un conto è di 1000 euro");
                return;
                } else {
                Saldo = importo; 
                ContoAperto = true;
                Console.WriteLine($"Conto aperto. Saldo di {Saldo} euro.");
            }
        }

        public void Versamento(double importo)
        {
            Saldo += importo;
            Console.WriteLine($"Versamento di {importo} euro. Saldo di {Saldo} euro.");
        }

        public void Prelievo(double importo)
        {
            Saldo -= importo;
            Console.WriteLine($"Prelievo di {importo} euro. Saldo di {Saldo} euro.");
        }
    }
}
