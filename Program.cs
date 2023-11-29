using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L25_numberSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 15;
            int minNumber = 0;
            int maxNumber = 100;
            int[] mainArray = new int[arraySize];
            bool isSorting = true;

            Console.WriteLine("Изначальный массив:");

            for (int i = 0; i < arraySize; i++)
            {
                mainArray[i] = random.Next(minNumber, maxNumber + 1);
                Console.Write(mainArray[i] + " ");
            }
            Console.WriteLine('\n');

            while (isSorting)
            {
                isSorting = false;

                for (int i = 0; i < arraySize - 1; i++)
                {
                    if (mainArray[i] > mainArray[i + 1])
                    {
                        int tempNumber = mainArray[i];
                        mainArray[i] = mainArray[i + 1];
                        mainArray[i + 1] = tempNumber;
                        isSorting = true;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив:");

            foreach (var item in mainArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
