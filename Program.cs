using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pavlovlala2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = rnd.Next(2, 10);
            int[,] matrix = new int[count, count];

            Console.WriteLine("Матрица изначально:");

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    matrix[i, j] = rnd.Next(99);
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            int currentZeroCount = 0;
            int maxZeroCount = 0;
            int neededString = new int();
            int[,] newMatrix = new int[count, count];
            bool hasZero = false;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        currentZeroCount++;
                        hasZero = true;
                    }
                }
                if (currentZeroCount > maxZeroCount)
                {
                    maxZeroCount = currentZeroCount;
                    neededString = i;
                }
                currentZeroCount = 0;
                Console.WriteLine();
            }

            Console.WriteLine("Матрица без нужно строки:");

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (i == neededString && hasZero)
                    {
                        break;
                    }
                    else
                    {
                        newMatrix[i, j] = matrix[i, j];
                        Console.Write(newMatrix[i, j] + "  ");
                    }

                }

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}

