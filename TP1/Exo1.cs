using System;

namespace TP1
{
    public class Exo1
    {
        protected int[] array;

        public Exo1(int arraySize)
        {
            array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("Entrez la valeur numéro : " + (i + 1));
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public override string ToString()
        {
            string stringReturn = "|";

            foreach (var item in array)
            {
                stringReturn += item + "|";
            }

            return stringReturn;
        }
    }
}