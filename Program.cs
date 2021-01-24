using System;

namespace WordSearchPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionaryArray = { "hi" };
            char[,] grid = new char[5, 5] {
                { 'a', 'b', 'c', 'd', 'e' },
                { 'f', 'g', 'h', 'i', 'j' },
                { 'h', 'e', 'l', 'l', 'o' },
                { 'k', 'l', 'm', 'n', 'o' },
                { 'p', 'q', 'r', 's', 'h' }
            };

            for (int arrayPosition = 0; arrayPosition < dictionaryArray.Length; arrayPosition++)
            {
                char[] charsToSearchFor = splitWordIntoCharacters(dictionaryArray[arrayPosition]);

                for (int charsPositon = 0; charsPositon < charsToSearchFor.Length; charsPositon++)
                {

                }
            }
            
            



            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (grid[r, c] == 'h')
                    {
                        Console.WriteLine($"{r}, {c}");
                    }
                }


            }
        }

        private static char[] splitWordIntoCharacters(string s)
        {
            return s.ToCharArray();
        }
    }
}
