using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SecondTask
    {
        public static void Logic()
        {
            Console.Write("Enter array size -> ");
            bool isArraySizeANumber = int.TryParse(Console.ReadLine(), out int arraySize);
            if (isArraySizeANumber)
            {
                if (arraySize > 0)
                {
                    float[] initialArray = ArrayInput(arraySize);
                    Console.WriteLine("Initial Array");
                    ArrayOutput(initialArray);
                    int firstNegativeElementIndex = Array.IndexOf(initialArray, initialArray.FirstOrDefault(element => element < 0));
                    if (firstNegativeElementIndex != -1)
                    {
                        Array.Sort(initialArray, 0, firstNegativeElementIndex);
                    }
                    else
                    {
                        Console.WriteLine("There are no negative elements in array ");
                    }
                    Console.WriteLine("Result Array");
                    ArrayOutput(initialArray);

                }
                else
                {
                    Console.WriteLine("Array size should be greater than zero");
                }
            }
            else
            {
                Console.WriteLine("Array size should be a number");
            }
        }
        private static float[] ArrayInput(int arraySize)
        {
            float[] initialArray = new float[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter {i + 1} element -> ");
                bool isElementANumber = float.TryParse(Console.ReadLine(), out float element);
                if (isElementANumber)
                    initialArray[i] = element;
                else
                {
                    Console.WriteLine("It's not a float number.Try again");
                    i--;
                }
            }
            return initialArray;
        }

        private static void ArrayOutput(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }
    }
}
