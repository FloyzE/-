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

            Console.WriteLine("Матрица изначально");

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

            for (int i = 0; i < count; i++ )
                {
                for(int j = 0; j < count; j++)
                    {
                     if(matrix[i,j] == 0)
                        {
                        currentZeroCoutn++;
                        hasZero = true;

                        }
                    }    

                }








        }
        
    }

    
  




    


