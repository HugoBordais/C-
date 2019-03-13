using System;

namespace TP1
{
    public class Exo5
    {
        private long nbRiz;

        public Exo5( int nbCase )
        {
            for (int i = 1; i <= nbCase; i++)
            {
                if (nbRiz == 0)
                {
                    nbRiz = 1;
                }
                else
                {
                    nbRiz += nbRiz * 2;
                    Console.WriteLine( nbRiz );
                }
            }
            
            Console.WriteLine( "Pour un échiquier de " + nbCase + " cases il y a " + nbRiz + " grains de riz.");
        }
    }
}