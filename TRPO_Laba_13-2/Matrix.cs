using System.Linq;

namespace TRPO_Laba_13_2
{
    static public class Matrix
    {
        static public int[][] SortSum(int[][] matrix)
        {
            int[] vs = new int[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                vs[i] = matrix[i].Sum();
            }

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (vs[i] > vs[i + 1])
                    {
                        var temp = matrix[j];
                        matrix[j] = matrix[j + 1];
                        matrix[j + 1] = temp;
                    }
                }
            }
            return matrix;
        }

        static public int[][] SortPr(int[][] matrix)
        {
            int[] vs = new int[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                vs[i] = Pr(matrix[i]);
            }


            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (vs[i] > vs[i + 1])
                    {
                        var temp = matrix[j];
                        matrix[j] = matrix[j + 1];
                        matrix[j + 1] = temp;
                    }
                }
            }
            return matrix;
        }

        static private int Pr(int[] mas)
        {
            int pr = 1;
            foreach (var num in mas)
            {
                pr *= num;
            }
            return pr;
        }
    }
}
