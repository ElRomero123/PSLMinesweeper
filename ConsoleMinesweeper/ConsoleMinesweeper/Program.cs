using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMinesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            Console.WriteLine("Hola, como están");
            b.CreateArray(10, 15, 15);
            //b.PrintBoard();
            Console.ReadLine();
        }
    }
}
