using System;
using System.Collections;
using System.Collections.Generic;

namespace LaSirenaMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;
            Console.WriteLine("Inserte la cantidad de columnas: ");
            columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserte la cantidad de filas: ");
            rows = Convert.ToInt32(Console.ReadLine());
            BinaryMatrixRandomGenerator BMRG = new BinaryMatrixRandomGenerator();
            int [,] matrix = BMRG.Generator(rows, columns);
            
            
            Dictionary <string, string> buildings = new Dictionary <string, string>();

            int buildingsCount = 0, n = 1, left, right, down;
            string current = "";
            string pairRight = "";
            string pairDown = "";

            SpecialConflictMatrix obj = new SpecialConflictMatrix();
            matrix = obj.GetSpecialMatrix();
            Console.WriteLine("Printing Matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            

            for (int i = 0; i<rows;i++)
            {
                for (int j = 0; j<columns; j++)
                {
                    if (matrix[i, j] == 0) { continue; }
                    n = 1;
                    left = j - 1;
                    right = j + 1;
                    down = i + 1;
                    current = Convert.ToString($"{i}{j}");
                    pairRight = Convert.ToString($"{i}{right}");
                    pairDown = Convert.ToString($"{down}{j}");

                    if (!buildings.ContainsKey(current) && matrix[i, j] == 1)
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
                    
                    

                    if(j+1 < columns && matrix[i, j + 1] == 1)
                    {
                        if (!buildings.ContainsKey(pairRight) && n==0)
                        {
                            buildings.Add(pairRight, buildings[current]);
                        }
                        if(!buildings.ContainsKey(pairRight) && n == 1)
                        {
                            buildings.Add(pairRight, buildings[current]);
                        }
                        if (buildings.ContainsKey(pairRight) && buildings[pairRight]!= buildings[current])
                        {
                            buildingsCount--;
                        }
                        
                    }
                    
                }
            }

            Console.WriteLine(buildingsCount);
            Console.WriteLine("Gracias!");
            
        }
    }
}
