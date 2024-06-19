using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_06_24
{
    public class Algoritmo
    {
      
     


        public void InserisciNumero()
        {
            Console.WriteLine("Inserisci un numero per la dimensione dell'array: ");           
           int n = int.Parse(Console.ReadLine());
            int[] numeri = new int[n];

           
            
            for (int i = 0; i < numeri.Length; i++)
            {
                numeri[i] = i + 1;
            }
            int somma = 0;
            foreach (int numero in numeri)
            {
              
                somma += numero;
                
            }

            double media = somma / numeri.Length;

            Console.WriteLine($"La somma dei numeri è {somma}");
            Console.WriteLine($"La media dei numeri è {media}");
        }
    }
}
