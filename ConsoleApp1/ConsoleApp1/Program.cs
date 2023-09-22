using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 第一個功能：顯示化學元素符號
            //DisplayChemicalSymbols();

            // 第二個功能：模擬擲兩個骰子並計算和
            SimulateDiceRoll();
        }

        // 第一個功能：顯示化學元素符號
        private static void DisplayChemicalSymbols()
        {
            string input;
            do
            {
                // Explanation: Create an array of the symbols for the first 10 elements
                string[] symbols = { "H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne" };

                // Explanation: Print each symbol on its own line
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(symbols[i]);
                }

                // Don't add or modify any code below this comment
                input = Console.ReadLine();
            } while (input[0] != 'q');
        }

        // 第二個功能：模擬擲兩個骰子並計算和
        private static void SimulateDiceRoll()
        {
            RandomNumberGenerator.Initialize();

            // create two dice
            Die die1 = new Die(10);
            Die die2 = new Die(30);

            // tell the dice to roll themselves
            die1.Roll();
            die2.Roll();


            // print the top sides and the sum of the dice
            Console.WriteLine("Die 1 NumSides: " + die1.NumSides);
            Console.WriteLine("Die 2 NumSides: " + die2.NumSides);

            Console.WriteLine("Die 1 TopSide: " + die1.TopSide);
            Console.WriteLine("Die 2 TopSide: " + die2.TopSide);
            int sum = die1.TopSide + die2.TopSide;
            Console.WriteLine("Sum of Dice: " + sum);
        }
    }
}


