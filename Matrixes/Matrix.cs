using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes;

internal class Matrix
{
    private int columns, rows;
    private int[,] matrix;
    Random rand = new Random();

    public Matrix()
    {
        Console.WriteLine("Enter the number of columns: ");
        columns = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of rows: ");
        rows = int.Parse(Console.ReadLine());

        matrix = new int[columns, rows];
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rand.Next(101);
            }
        }
    }

    public void PrintTheMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(matrix[i, j] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else 
                {
                    Console.Write(matrix[i, j] + " ");
                }
                    
            }

            Console.WriteLine();
        }      
    }

    public int FindTrace()
    {
        var sum = 0;

        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }
}

