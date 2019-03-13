using System;
using System.ComponentModel.DataAnnotations;

namespace TP1
{
    public class Exo4
    {
        private bool play = true;
        
        public Exo4()
        {
            while (play)
            {
                startTheGame();
                
                Console.WriteLine( "Voulez-vous recommencer ? [1] pour oui [0] pour non");
                
                int userPlay = int.Parse(Console.ReadLine());
                if (userPlay == 0)
                {
                    play = false;
                }
            }
        }
    
        private void startTheGame()
        {
            Exo3 theGame = new Exo3();
        }
    }
}