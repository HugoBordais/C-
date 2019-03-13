using System;
using System.Collections;

namespace TP3
{
    public class Exo3
    {
        
        // Variable
      
        private ArrayList capitales = new ArrayList()
        {
            "Paris", "Madrid", "Londres", "Rome", "Genève", "Dublin", "Moscou", "Zurich", "Prague"
        };
        
        // Constructeur
        public Exo3()
        {
            Console.WriteLine("Inserez une chaine de caratère :");
            string caractere = Console.ReadLine().ToLower();
            Console.WriteLine("Le pays correspondant à votre saisie précédente ->" + caractere + " :");
            Filtre(caractere).WriteContent();
        }
        
        // Function
        ArrayList Filtre(string saisie)
        {
            ArrayList result = new ArrayList();

            foreach (string ville in capitales)
            {
                if (ville.ToLower().Contains(saisie))
                {
                    result.Add(ville);
                }   
            }

            return result;
        }
    }
}