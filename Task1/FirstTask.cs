using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class FirstTask
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
                    int firstOddElementIndex = Array.IndexOf(initialArray, initialArray.FirstOrDefault(element => element % 2 == 1));
                    if (firstOddElementIndex != -1)
                    {
                        float result = initialArray.Where(element => Array.IndexOf(initialArray, element) > firstOddElementIndex).ToArray().Sum();
                        if (result != 0)
                        {
                            Console.WriteLine($"Sum with this condition  = {result}");
                        }
                        else
                        {
                            Console.WriteLine("There are no elements after first odd element");
                        }

                    }
                    else
                    {
                        Console.WriteLine("There are no odd elements in array");
                    }

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
    }


}
