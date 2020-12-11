using System;

namespace TRPO_Laba_13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mas = new int[3][];
            mas[0] = new int[3] { 4, 8, -9 };
            mas[1] = new int[2] { 1, 3 };
            mas[2] = new int[2] { 4, 3 };
            while (true)
            {
                int switch_on = Convert.ToInt32(Console.ReadLine());
                switch (switch_on)
                {
                    case 1:
                        {
                            Func<int[][], int[][]> func = Matrix.SortSum;
                            func(mas);
                            arrayOutput(mas);
                            break;
                        }
                    case 2:
                        {
                            Func<int[][], int[][]> func = Matrix.SortSum;
                            func(mas);
                            arrayOutput(mas);
                            break;
                        }
                }
            }

        }

        private static void arrayOutput(int[][] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(string.Join(" ", mas[i]));
            }
        }

    }
}
