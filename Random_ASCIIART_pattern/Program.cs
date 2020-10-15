using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_ASCIIART_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Random_ASCII ART_Pattern - VERSION 2.0";
            Console.WriteLine(" ASCII ART PATTERN " + "(Playing With Me :) ╟ ╫ ∩ ╬ ╦ ║ ═ ▐ ▄ ∕∕ \\ ╒ ├ ╣ )");
            Console.WriteLine(" Choose Two Numbers Between ( 0 to 20 )");
            Console.WriteLine();
            //Console.Write("╟ ╫ ∩ ╬ ╦ ║ ═ ▐ ▄ ∕∕ \\ ╒ ├ ╣");


            //input value from user
            Console.Write(" input your first number : ");
            string input1 = Console.ReadLine();
            Console.Write(" input your second number : ");
            string input2 = Console.ReadLine();


            //input
            int index1 = 0;
            int index2 = 0;

            // symbols array 
            string[] symbol1 = { " ", "-", "╟", "╫", "∩", "╬", "╦", "║", "═", "▐", "▄", "┴", "\\", "╒", "├", "╣", "‡", "Ć", "*", "/", "┼" };
            string[] symbol2 = { "-", "+", "Ů", "╫", "╔", "╬", "╚", "╦", "║", "═", "▐", "▄", "┌", "┘", "╒", "├", "╣", "‡", "≡", "|", "┬" };

            try
            {

                index1 = Convert.ToInt32(input1);
                index2 = Convert.ToInt32(input2);
                Console.WriteLine();
                Console.WriteLine($" your choice was : [{symbol1[index1]}] & [{symbol2[index2]}]");

                // size of canvas (Matrix)
                int width = 70;
                int height = 12;
                Console.WriteLine();

                Random ran = new Random();
                //Matrix(nested for loops)
                for (int j = 0; ran.Next(j) < height; j++)
                {
                    int borderLine = 1;

                    for (int i = 1; i < width; i++)
                    {

                        int even1 = i % 2;

                        if (ran.Next(i / 2) < borderLine + 1 || ran.Next(i * 2) >= (height) - 1 || even1 < borderLine)
                        {

                            Console.Write(symbol1[index1]);

                        }
                        else
                        {
                            Console.Write(symbol2[index2]);

                        }

                    }
                    Console.WriteLine();
                }

            }
            catch
            {
                Console.WriteLine(" Please Input a Real Number Inside The Range && No Char ! ");
                Console.ReadKey();
            }

            Console.WriteLine();
            Console.WriteLine(" press any key to exit ...");
            Console.ReadKey();
        }
    }
}
