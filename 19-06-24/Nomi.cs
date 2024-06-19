using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_06_24
{
    public class NameList
    {
        string[] listaUtenti = { "gianmarco", "francesco", "ciro", "catello", "marza" };
        string utente="";
        bool trovato = false;

        
        public void CercaUtente()
        {
            Console.WriteLine("Inserisci il nome dell'utente da cercare: ");
            utente = Console.ReadLine();
            if(listaUtenti.Contains(utente))
            {
                Console.WriteLine("Utente trovato");
                trovato = true; 

            }
            else
            {
                Console.WriteLine("Utente non trovato");
            }
        }
    }

}
