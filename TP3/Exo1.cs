using System;
using System.Collections;

namespace TP3
{
    public class Exo1
    {
        // Constructeur
        public Exo1()
        {
            ArrayList l = new ArrayList();
            for (int i = 0; i <= 100; i++)
            {
                l.Add(i);
            }
            
            l.WriteContent();
        }
    }
}