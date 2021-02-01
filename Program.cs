using System;

namespace WordSearchPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionaryArray = { "hi", "hello", "afhkp", "hgj" };
            char[,] grid = new char[5, 5] {
                { 'a', 'b', 'c', 'd', 'e' },
                { 'f', 'g', 'h', 'i', 'j' },
                { 'h', 'e', 'l', 'l', 'o' },
                { 'k', 'l', 'm', 'n', 'o' },
                { 'p', 'q', 'r', 's', 't' }
            };
            bool wordFound = false;

            for (int arrayPosition = 0; arrayPosition < dictionaryArray.Length; arrayPosition++)
            {
                // Split word into array of char
                char[] charsToSearchFor = dictionaryArray[arrayPosition].ToCharArray();

                // Search for first letter
                for (int r = 0; r < 5; r++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        if (grid[r, c] == charsToSearchFor[0])
                        {
                            wordFound = false;

                            // Search for subsequent letter horizontally
                            wordFound = searchForLettersHorizontal(grid, charsToSearchFor, r, c);

                            if (wordFound)
                            {
                                printWordFound("Horizontal", dictionaryArray[arrayPosition]);
                            }

                            // Search for subsequent letter horizontally
                            wordFound = searchForLettersVertical(grid, charsToSearchFor, r, c);

                            if (wordFound)
                            {
                                printWordFound("Vertical", dictionaryArray[arrayPosition]);
                            }
                        }
                    }
                }
            }
        }

        private static void printWordFound(string horizontalOrVertical, string word)
        {
            
            Console.WriteLine($"{horizontalOrVertical} word found: {word}");
            Console.WriteLine();
        }

        private static bool searchForLettersHorizontal(char[,] grid, char[] charsToSearchFor, int r, int c)
        {
            for (int horizontalSearch = 1; horizontalSearch < charsToSearchFor.Length; horizontalSearch++)
            {
                if (grid[r, c + horizontalSearch] != charsToSearchFor[horizontalSearch])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool searchForLettersVertical(char[,] grid, char[] charsToSearchFor, int r, int c)
        {
            for (int verticalSearch = 1; verticalSearch < charsToSearchFor.Length; verticalSearch++)
            {
                if (grid[r + verticalSearch, c] != charsToSearchFor[verticalSearch])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

