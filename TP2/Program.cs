using System;
using System.Collections.Generic;
using TP2._2_thegame;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    Exo2    */
            Joueur j1 = new Joueur("Hugo", "azertyuiop");
            Joueur j2 = new Joueur("Max", "azertyuiop");
            Joueur j3 = new Joueur("Louise", "azertyuiop");
            Joueur j4 = new Joueur("Antinea", "azertyuiop");
        
            PartieMultiJoueurs partie1 = new PartieMultiJoueurs();
            j1.Connect(partie1);
            j2.Connect(partie1);
            j3.Connect(partie1);
            j4.Connect(partie1);
            
            Console.WriteLine( partie1 );
        }
    }
}