using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryMatrixClusterFinder
{
    /// <summary>
    /// This class implements the methods of random generation of matrices, 
    /// printing a matrix, and find the quantity of clusters in the matrix.
    /// </summary>
    public class MatrixUtilities
    {
        /// <summary>
        /// Generates a random binary matrix into a bidimensional interger array.
        /// </summary>
        /// <returns>
        /// This method returns an interger bidimensional array.
        /// </returns>
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

        public void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            Console.WriteLine("Impresión de  Matriz: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Find the amount of clusters in a given matrix.
        /// </summary>
        /// <returns>
        /// Returns an interger value with the amount of clusters.
        /// </returns>
        public int FindClusters(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            Dictionary<string, string> buildings = new Dictionary<string, string>();

            int buildingsCount = 0, n = 1, right, down;
            string current = "";
            string pairRight = "";
            string pairDown = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == 0) { continue; }
                    n = 1;

                    right = j + 1;
                    down = i + 1;
                    current = Convert.ToString($"{i},{j}");
                    pairRight = Convert.ToString($"{i},{right}");
                    pairDown = Convert.ToString($"{down},{j}");

                    if (!buildings.ContainsKey(current))
                    {
                        n = 0;
                        if (i + 1 < rows && matrix[i + 1, j] == 1)
                        {
                            buildings.Add(pairDown, current);
                        }

                        buildings.Add(current, current);
                        buildingsCount++;
                    }
                    else if (i + 1 < rows)
                    {
                        if (matrix[i + 1, j] == 1 && matrix[i, j] == 1)
                        {
                            buildings.Add(pairDown, buildings[current]);
                        }
                    }


                    if (j + 1 < columns && matrix[i, j + 1] == 1)
                    {
                        if (!buildings.ContainsKey(pairRight) && n == 0)
                        {
                            buildings.Add(pairRight, buildings[current]);
                        }
                        if (!buildings.ContainsKey(pairRight) && n == 1)
                        {
                            buildings.Add(pairRight, buildings[current]);
                        }

                        //If two 1s meet and both have been discovered with different values,
                        // then they must belong to the same cluster, therefore the cluster count is
                        // off by one and needs to be decremented.
                        if (buildings.ContainsKey(pairRight) &&
                            buildings[pairRight] != buildings[current])
                        {
                            buildingsCount--;
                        }

                    }

                }
            }

            return buildingsCount;
        }
    }
}
