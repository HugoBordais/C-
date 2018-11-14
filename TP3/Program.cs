using System.Collections;
using System.Collections.Concurrent;

namespace TP3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ArrayList l = new ArrayList();
            for (int i = 0; i < 101; i++)
            {
                l.Add(i);
            }
            l.Contenu();
        }
    }
}