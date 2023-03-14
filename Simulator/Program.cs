using System;

namespace Simulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
            Console.CursorVisible = false;
            char[,] map =
            {
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ','#',' ',' ',' ',' ','X',' ',' ',' ',' ',' ','#'},
            {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ','#','#','#','#',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ','#','#','X','#',' ',' ',' ','#',' ',' ',' ','#'},
            {'#',' ','#','#',' ','#',' ',' ',' ','#',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#'},
            {'#',' ','#','#','#','#',' ',' ',' ','#',' ',' ',' ','#'},
            {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ','#',' ',' ','X',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };

            int userX = 1; int userY = 1;
            char[] bag = new char[0];
            
            while (true)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write("Сумка: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                  }
                Console.SetCursorPosition(userY, userX);
                Console.Write('@');
                ConsoleKeyInfo charKey = Console.ReadKey();

                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;
                }
                if (map[userX, userY] == 'X')
                {
                    map[userX, userY] = 'O';


                    char[]tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = 'X';
                    bag = tempBag;
                   
                }

                Console.Clear();
            }
        }
    }
}