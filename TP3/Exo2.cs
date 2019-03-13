using System.Collections;
using System;

namespace TP3
{
    public class Exo2
    {
        // Variable
        delegate bool delIs(int a, int b);
        ArrayList array = new ArrayList();
        
        // Constructeur
        public Exo2()
        {
            for (int i = 1; i <= 100; i++)
            {
                array.Add(i);
            }
            
            Console.WriteLine( "Inserez un nombre" );
            int number = Int32.Parse(Console.ReadLine());
            Filter(number).WriteContent();
        }
        
        // Function
        ArrayList Filter(int number)
        {
            delIs multiple = (a, b) => a % b == 0;
            ArrayList result = new ArrayList();
            
            foreach (int elem in array)
            {
                if (multiple(elem, number))
                {
                    result.Add(elem);
                }
            }
            return result;
        }

    }
}