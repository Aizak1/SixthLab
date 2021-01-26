using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ThirdTask
    {

        public static void Logic()
        {
            Console.Write("Enter amount of rows  -> ");
            bool isAmountOfRawsANumber = int.TryParse(Console.ReadLine(), out int rows);
            Console.Write("Enter amount of columns  -> ");
            bool isAmountOfColumnsANumber = int.TryParse(Console.ReadLine(), out int columns);
            if (isAmountOfColumnsANumber && isAmountOfRawsANumber)
            {
                if (rows > 0 && columns > 0)
                {
                    float[,] initialMatrix = MatrixInput(rows, columns);
                    bool[] hasPositiveElementInColumm = new bool[columns];
                    Console.WriteLine("Initial Matrix");
                    MatrixOutPut(initialMatrix);
                    List<float> sumByColumns = new List<float>();

                    for (int i = 0; i < columns; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (initialMatrix[j, i] > 0)
                            {
                                hasPositiveElementInColumm[i] = true;
                                continue;
                            }
                        }
                    }


                    for (int i = 0; i < columns; i++)
                    {
                        if (hasPositiveElementInColumm[i])
                        {
                            float sumOfColumn = 0;
                            for (int j = 0; j < rows; j++)
                            {
                                sumOfColumn += initialMatrix[j, i];
                            }
                            sumByColumns.Add(sumOfColumn);
                        }
                    }
                    if (sumByColumns.Count != 0)
                        SumOutput(sumByColumns);
                    else
                        Console.WriteLine("There are no columns with this condition");

                }
                else
                {
                    Console.WriteLine("Size of matrix should be greater than zero");
                }

            }
            else
            {
                Console.WriteLine("Matrix size should be a number");
            }
        }
        private static float[,] MatrixInput(int rows, int columns)
        {
            float[,] initialArray = new float[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter {i + 1},{j + 1} element -> ");
                    bool isElementANumber = float.TryParse(Console.ReadLine(), out float element);
                    if (isElementANumber)
                        initialArray[i, j] = element;
                    else
                    {
                        Console.WriteLine("It's not a float number.Try again");
                        j--;
                    }
                }
            }
            return initialArray;
        }

        private static void MatrixOutPut(float[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        private static void SumOutput(List<float> sumList)
        {
            for (int i = 0; i < sumList.Count; i++)
            {
                Console.WriteLine($"Sum of {i + 1} column = {sumList[i]}");
            }
        }
    }
}
