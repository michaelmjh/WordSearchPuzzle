using System;

namespace WordSearchAllDirections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionaryArray = { "hi", "hello", "afhkp", "test", "tool", "tell" };
            char[,] grid = new char[5, 5] {
                { 'a', 'b', 'c', 'd', 'e' },
                { 'f', 'l', 'h', 'i', 'l' },
                { 'h', 'e', 'l', 'l', 'o' },
                { 'k', 'l', 'm', 'e', 'o' },
                { 'p', 't', 's', 'e', 't' }
            };

            //make into for each
            foreach (string word in dictionaryArray)
            {
                for (int row = 0; row < 5; row++)
                {
                    for (int column = 0; column < 5; column++)
                    {
                        for (int searchDirection = 0; searchDirection < 8; searchDirection++)
                        {
                            FindWord(grid, row, column, word, 0, searchDirection);
                        }
                    }
                }
            }
        }

        public static void FindWord(char[,] grid,  int r, int c, string wordToSearchFor, int letterCount, int searchDirection)
        {
            // Check letter being search for is with the bounds of the word and return if not
            if (letterCount >= wordToSearchFor.Length)
            {
                return;
            }
            // Check letter being compared is within bounds of the grid and return if not
            else if (r < 0 || r >= grid.GetLength(0) || c < 0 || c >= grid.GetLength(1))
            {
                return;
            }
            // Return if grid letter does not match letter being searched for
            if (grid[r, c] != wordToSearchFor[letterCount])
            {
                return;
            }
            else
            {
                // If letter found is last in the word, print word and return
                if (letterCount == (wordToSearchFor.Length - 1))
                {
                    Console.WriteLine($"Word found - {wordToSearchFor}");
                    return;
                }
                // else continue searching for next letter
                else
                {
                    switch (searchDirection)
                    {
                        case 0:
                            FindWord(grid, r, c + 1, wordToSearchFor, letterCount + 1, searchDirection);
                            break;
                        case 1:
                            FindWord(grid, r + 1, c + 1, wordToSearchFor, letterCount + 1, searchDirection);
                            break;
                        case 2:
                            FindWord(grid, r + 1, c, wordToSearchFor, letterCount + 1, searchDirection);
                            break;
                        case 3:
                            FindWord(grid, r + 1, c - 1, wordToSearchFor, letterCount + 1, searchDirection);
                            break;
                        case 4:
                            FindWord(grid, r, c - 1, wordToSearchFor, letterCount + 1, searchDirection);
                            break;
                        case 5:
                            FindWord(grid, r - 1, c - 1, wordToSearchFor, letterCount + 1, searchDirection);
                            break;
                        case 6:
                            FindWord(grid, r - 1, c, wordToSearchFor, letterCount + 1, searchDirection);
                            break;
                        case 7:
                            FindWord(grid, r - 1, c + 1, wordToSearchFor, letterCount + 1, searchDirection);
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                }
            }
        }
    }
}