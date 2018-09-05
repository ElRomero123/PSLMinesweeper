using System;
using System.Linq;

namespace ConsoleMinesweeper
{
    public class Board
    {
        private char[,] ArrayBoard;
        private int width;
        private int height;
        private int mines;
        private Random AleatoryNumber = new Random();

        public void CreateArray(int height, int width, int mines)
        {
            ArrayBoard = new char[height, width];
            this.width = width;
            this.height = height;
            this.mines = mines;

            PutMines();
        }

        private void PutMines()
        {
            int[] cX = Aleatorio(mines, width);
            int[] cY = Aleatorio(mines, height);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hola");
                Console.WriteLine(cX[i] + " , " + cY[i]);
                //ArrayBoard[cX[i], cY[i]] = '*';
            }
        }

        private int[] Aleatorio(int size, int range)
        {
            int[] ns = new int[size];

            ns[0] = AleatoryNumber.Next(0, range);

            for (int c1 = 1; c1 < ns.Length; c1++)
            {
                int na = AleatoryNumber.Next(0, range);
                int c2 = 0;

                while (c2 < c1)
                {
                    if (ns[c2] == na)
                    {
                        na = AleatoryNumber.Next(0, range);
                        c2 = 0;
                        continue;
                    }
                    else
                    {
                        ns[c1] = na;
                    }
                    c2++;
                }
            }

            return ns;
        }

        public void PrintBoard()
        {
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < width; j++)
                {
                    Console.Write(ArrayBoard[i, j]);
                }
            }
        }
    }  
}
