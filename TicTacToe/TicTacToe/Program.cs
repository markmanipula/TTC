using System;

namespace TicTacToe
{
    class Program
    {

        public static string[,] TicTacToeGrid = new string[3, 3];
        public static int rowLength = TicTacToeGrid.GetLength(0);
        public static int colLength = TicTacToeGrid.GetLength(1);

        //this prints the current grid of the tic tac toe
        public static void printGrid()
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", TicTacToeGrid[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        static void Main()
        {
            int tie = 0;

            TicTacToeGrid.SetValue(".", 0, 0);
            TicTacToeGrid.SetValue(".", 0, 1);
            TicTacToeGrid.SetValue(".", 0, 2);
            TicTacToeGrid.SetValue(".", 1, 0);
            TicTacToeGrid.SetValue(".", 1, 1);
            TicTacToeGrid.SetValue(".", 1, 2);
            TicTacToeGrid.SetValue(".", 2, 0);
            TicTacToeGrid.SetValue(".", 2, 1);
            TicTacToeGrid.SetValue(".", 2, 2);

            bool Winner = false;

            while (!Winner)
            {
                Console.WriteLine("Player X's turn");
                int playerInputX = int.Parse(Console.ReadLine());

                if (playerInputX == 1)
                {
                    TicTacToeGrid[0, 0] = "X";
                    printGrid();
                    tie++;
                }
                if (playerInputX == 2)
                {
                    TicTacToeGrid[0, 1] = "X";
                    printGrid();
                    tie++;
                }
                if (playerInputX == 3)
                {
                    TicTacToeGrid[0, 2] = "X";
                    printGrid();
                    tie++;
                }
                if (playerInputX == 4)
                {
                    TicTacToeGrid[1, 0] = "X";
                    printGrid();
                    tie++;
                }
                if (playerInputX == 5)
                {
                    TicTacToeGrid[1, 1] = "X";
                    printGrid();
                    tie++;
                }
                if (playerInputX == 6)
                {
                    TicTacToeGrid[1, 2] = "X";
                    printGrid();
                    tie++;
                }
                if (playerInputX == 7)
                {
                    TicTacToeGrid[2, 0] = "X";
                    printGrid();
                    tie++;
                }
                if (playerInputX == 8)
                {
                    TicTacToeGrid[2, 1] = "X";
                    printGrid();
                    tie++;
                }
                if (playerInputX == 9)
                {
                    TicTacToeGrid[2, 2] = "X";
                    printGrid();
                    tie++;
                }

                if (TicTacToeGrid[0, 0] == "X" && TicTacToeGrid[0, 1] == "X" && TicTacToeGrid[0, 2] == "X")
                {
                    Console.WriteLine("Player X wins!");
                    break;
                }
                if (TicTacToeGrid[1, 0] == "X" && TicTacToeGrid[1, 1] == "X" && TicTacToeGrid[1, 2] == "X")
                {
                    Console.WriteLine("Player X wins!");
                    break;
                }
                if (TicTacToeGrid[2, 0] == "X" && TicTacToeGrid[2, 1] == "X" && TicTacToeGrid[2, 2] == "X")
                {
                    Console.WriteLine("Player X wins!");
                    break;
                }
                if (TicTacToeGrid[0, 0] == "X" && TicTacToeGrid[1, 0] == "X" && TicTacToeGrid[2, 0] == "X")
                {
                    Console.WriteLine("Player X wins!");
                    break;
                }
                if (TicTacToeGrid[0, 1] == "X" && TicTacToeGrid[1, 1] == "X" && TicTacToeGrid[2, 1] == "X")
                {
                    Console.WriteLine("Player X wins!");
                    break;
                }
                if (TicTacToeGrid[0, 2] == "X" && TicTacToeGrid[1, 2] == "X" && TicTacToeGrid[2, 2] == "X")
                {
                    Console.WriteLine("Player X wins!");
                    break;
                }
                if (TicTacToeGrid[0, 0] == "X" && TicTacToeGrid[1, 1] == "X" && TicTacToeGrid[2, 2] == "X")
                {
                    Console.WriteLine("Player X wins!");
                    break;
                }
                if (TicTacToeGrid[0, 2] == "X" && TicTacToeGrid[1, 1] == "X" && TicTacToeGrid[2, 0] == "X")
                {
                    Console.WriteLine("Player X wins!");
                    break;
                }

                Console.WriteLine("Player O's turn");
                int playerInputO = int.Parse(Console.ReadLine());

                if (playerInputO == 1)
                {
                    TicTacToeGrid[0, 0] = "O";
                    printGrid();
                    tie++;
                }
                if (playerInputO == 2)
                {
                    TicTacToeGrid[0, 1] = "O";
                    printGrid();
                    tie++;
                }
                if (playerInputO == 3)
                {
                    TicTacToeGrid[0, 2] = "O";
                    printGrid();
                    tie++;
                }
                if (playerInputO == 4)
                {
                    TicTacToeGrid[1, 0] = "O";
                    printGrid();
                    tie++;
                }
                if (playerInputO == 5)
                {
                    TicTacToeGrid[1, 1] = "O";
                    printGrid();
                    tie++;
                }
                if (playerInputO == 6)
                {
                    TicTacToeGrid[1, 2] = "O";
                    printGrid();
                    tie++;
                }
                if (playerInputO == 7)
                {
                    TicTacToeGrid[2, 0] = "O";
                    printGrid();
                    tie++;
                }
                if (playerInputO == 8)
                {
                    TicTacToeGrid[2, 1] = "O";
                    printGrid();
                    tie++;
                }
                if (playerInputO == 9)
                {
                    TicTacToeGrid[2, 2] = "O";
                    printGrid();
                    tie++;
                }

                if (TicTacToeGrid[0, 0] == "O" && TicTacToeGrid[0, 1] == "O" && TicTacToeGrid[0, 2] == "O")
                {
                    Console.WriteLine("Player O wins!");
                    break;
                }
                if (TicTacToeGrid[1, 0] == "O" && TicTacToeGrid[1, 1] == "O" && TicTacToeGrid[1, 2] == "O")
                {
                    Console.WriteLine("Player O wins!");
                    break;
                }
                if (TicTacToeGrid[2, 0] == "O" && TicTacToeGrid[2, 1] == "O" && TicTacToeGrid[2, 2] == "O")
                {
                    Console.WriteLine("Player O wins!");
                    break;
                }
                if (TicTacToeGrid[0, 0] == "O" && TicTacToeGrid[1, 0] == "O" && TicTacToeGrid[2, 0] == "O")
                {
                    Console.WriteLine("Player O wins!");
                    break;
                }
                if (TicTacToeGrid[0, 1] == "O" && TicTacToeGrid[1, 1] == "O" && TicTacToeGrid[2, 1] == "O")
                {
                    Console.WriteLine("Player O wins!");
                    break;
                }
                if (TicTacToeGrid[0, 2] == "O" && TicTacToeGrid[1, 2] == "O" && TicTacToeGrid[2, 2] == "O")
                {
                    Console.WriteLine("Player O wins!");
                    break;
                }
                if (TicTacToeGrid[0, 0] == "O" && TicTacToeGrid[1, 1] == "O" && TicTacToeGrid[2, 2] == "O")
                {
                    Console.WriteLine("Player O wins!");
                    break;
                }
                if (TicTacToeGrid[0, 2] == "O" && TicTacToeGrid[1, 1] == "O" && TicTacToeGrid[2, 0] == "O")
                {
                    Console.WriteLine("Player O wins!");
                    break;
                }

                if (tie == 8)
                {
                    Console.WriteLine("It's a tie");
                    break;
                }

            }
        }
        
    }
}
