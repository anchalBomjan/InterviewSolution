
using System;
using System.Collections.Generic;
namespace LetterCombinationofPhoneNumber
{

    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return new List<string>();

            // Mapping of digits to letters
            string[] letters = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            // this helps to store the the combinations  in the forms of string in list
            List<string> result = new List<string>();


            // Using the recursive functions
            void Backtrack(int index, string currentCombination)
            {

                //suppose 23 then digita.length=2
                if (index == digits.Length)
                {
                    result.Add(currentCombination);
                    return;
                }


                // digits[index] gets the character at index position in the input string digits
                // digits[index]-'0'  convert  the charater into interger
                // leters[digits[index]-'0']Uses the interger as  an index  retrive the crossproding letters  mapping from the letters arrary
                string possibleLetters = letters[digits[index] - '0'];
                foreach (char letter in possibleLetters)
                {
                    Backtrack(index + 1, currentCombination + letter);
                }
            }

            Backtrack(0, "");
            return result;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number between 2-9 (or leave empty): ");
            string input = Console.ReadLine();

            // Handle empty input explicitly
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("[]"); // Exact format as required
                return;
            }

            // Validate input (only digits 2-9 allowed)
            if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[2-9]+$"))
            {
                Console.WriteLine("Invalid input. Please enter only digits between 2-9.");
                return;
            }

            Solution solution = new Solution();
            IList<string> combinations = solution.LetterCombinations(input);

            // Print output in the exact expected format
            Console.WriteLine(combinations.Count > 0 ? "[\"" + string.Join("\", \"", combinations) + "\"]" : "[]");

        }
    }
}
