using System;

namespace WordSearchAllDirections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionaryArray = { "hello", "all", "afhkp", "ill", "test", "tell", "tool", "lie" };
            char[,] grid = new char[5, 5] {
                { 'a', 'b', 'c', 'd', 'e' },
                { 'f', 'l', 'h', 'i', 'l' },
                { 'h', 'e', 'l', 'l', 'o' },
                { 'k', 'l', 'm', 'e', 'o' },
                { 'p', 't', 's', 'e', 't' }
            };

            //For each item in dictionary array
            foreach (string word in dictionaryArray)
            {
                //Set row to search
                for (int row = 0; row < 5; row++)
                {
                    //Set column to search
                    for (int column = 0; column < 5; column++)
                    {
                        //Set x search direction
                        for (int searchDirectionX = -1; searchDirectionX <= 1; searchDirectionX++)
                        {
                            //Set y search direction
                            for(int searchDirectionY = -1; searchDirectionY <= 1; searchDirectionY++)
                            {
                                //Check x and y search direction are not both 0
                                if (searchDirectionX == 0 && searchDirectionY == 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    //Search for word
                                    FindWord(grid, row, column, word, 0, searchDirectionX, searchDirectionY);
                                }
                            }
                            
                        }
                    }
                }
            }
        }

        public static void FindWord(char[,] grid,  int r, int c, string wordToSearchFor, int letterCount, int searchDirectionX, int searchDirectionY)
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
                // else move onto next letter in word
                else
                {
                    FindWord(grid, r + searchDirectionY, c + searchDirectionX, wordToSearchFor, letterCount + 1, searchDirectionX, searchDirectionY);
                
                }
            }
        }
    }
}