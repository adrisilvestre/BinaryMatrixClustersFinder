using System;
using System.Collections.Generic;
using System.Text;

namespace LaSirenaMatrix
{
    public class BinaryMatrixRandomGenerator
    {
        public int[,] Generator (int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(0, 2);
                }
            }

            return matrix;
        }
    }
}
