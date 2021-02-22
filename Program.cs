using System;

namespace WordSearchAllDirections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionaryArray = { "hi", "hello", "afhkp" };
            char[,] grid = new char[5, 5] {
                { 'a', 'b', 'c', 'd', 'e' },
                { 'f', 'g', 'h', 'i', 'j' },
                { 'h', 'e', 'l', 'l', 'o' },
                { 'k', 'l', 'm', 'n', 'o' },
                { 'p', 'q', 'r', 's', 't' }
            };

            for (int arrayPosition = 0; arrayPosition < dictionaryArray.Length; arrayPosition++)
            {
                // Split word from dictionary into array of char


                char[] charsToSearchFor = dictionaryArray[arrayPosition].ToCharArray();


                for (int row = 0; row < 5; row++)
                {
                    for (int column = 0; column < 5; column++)
                    {

                        string foundWord = FindLetter(grid, charsToSearchFor, row, column, 0, "");

                        if (foundWord == dictionaryArray[arrayPosition])
                        {
                            Console.WriteLine($"Word found: {dictionaryArray[arrayPosition]}");

                        }
                    }
                }
            }
        }

        public static string FindLetter(char[,] grid, char[] charsToSearchFor, int r, int c, int letterCount, string wordBuild)
        {
            string word = wordBuild;

            if (letterCount >= charsToSearchFor.Length)
            {
                word = "out of bounds";
            }

            else if (r < 0 || r >= grid.GetLength(0) || c < 0 || c >= grid.GetLength(1))
            {
                word = "out of bounds";
            }

            if (grid[r, c] != charsToSearchFor[letterCount])
            {
                word = "letter not found";
            }
            else
            {
                word += grid[r, c];
                FindLetter(grid, charsToSearchFor, r, c + 1, 0, word);
            }

            Console.WriteLine(word);
            return word;
        }
    }
}