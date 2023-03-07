using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Class1
    {
        public bool MatrixJudge(int[][] matrix) { 
            int m = matrix.Length;
            int n = matrix[0].Length;
            //检查第一列中除第一个元素外的所有元素所在的对角线
            for (int i = 1; i < m; i++)
            {
                int x = i, y = 0;
                while (x < m && y < n)
                {
                    if (matrix[x][y] != matrix[i - 1][0]) return false;
                    x++;
                    y++;                       
                }
            }
            //检查第一行中除第一个元素外的所有元素所在的对角线
            for (int j = 1; j < n; j++)
            {
                int x = 0, y = j;
                while (x < m && y < n)
                {
                    if (matrix[x][y] != matrix[0][j - 1]) return false;
                    x++;
                    y++;
                }
            }
            return true;
        }
    }
}
