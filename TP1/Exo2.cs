using System;

namespace TP1
{
    public class Exo2 : Exo1
    {
        public Exo2(int arraySize) : base(arraySize)
        {
            Array.Sort(array);
        }
    }
}