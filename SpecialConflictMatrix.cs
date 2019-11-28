using System;
using System.Collections.Generic;
using System.Text;

namespace LaSirenaMatrix
{
    public class SpecialConflictMatrix
    {
         public int[,] GetSpecialMatrix()
        {
            int[,] specialMatrix = new int[,]
            {
                {1,1,0,0 },
                {0,0,1,0 },
                {0,0,0,0 },
                {1,0,1,1 },
                {1,1,1,1 }
            };
            return specialMatrix;
        }
    }
}
