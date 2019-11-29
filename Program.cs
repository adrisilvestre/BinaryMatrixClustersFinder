using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryMatrixClusterFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte la cantidad de filas: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserte la cantidad de columnas: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            MatrixUtilities BMRG = new MatrixUtilities();
            int[,] matrix = BMRG.Generator(rows, columns);

            /*SpecialConflictMatrix obj = new SpecialConflictMatrix();
           matrix = obj.GetSpecialMatrix();*/

            //Imprimir matriz.
            BMRG.PrintMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine($"La cantidad total de clústers es: {BMRG.FindClusters(matrix)}");

            Console.WriteLine("¡Gracias!");
            
        }
    }
}
