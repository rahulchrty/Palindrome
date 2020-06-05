using System;
using System.Collections.Generic;

namespace Palindrome.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of string:");
            string inputhLength = Console.ReadLine();
            int noOfLines = 0;
            Int32.TryParse(inputhLength, out noOfLines);
            List<string> inputList = new List<string>();
            Console.WriteLine("Enter list of inputs:");
            for(int i = 0; i < noOfLines; i++)
            {
                string input = Console.ReadLine();
                inputList.Add(input);
            }
            List<string> pal = GetAllPalindromes(inputList);
            Console.WriteLine("List of Palindrome:");
            foreach (string s in pal)
            {
                Console.WriteLine(s);
            }
        }

        public static List<string> GetAllPalindromes (List<string> inputList)
        {
            List<string> palindromeList = new List<string>();
            foreach (string eachInput in inputList)
            {
                bool isPalindrome = IsPalindrome(eachInput);
                if (isPalindrome)
                {
                    palindromeList.Add(eachInput);
                }
            }
            return palindromeList;
        }

        public static bool IsPalindrome(string input)
        {
            bool isPalindrome = false;
            char[] charArray = input.ToCharArray();
            for (int i = 0, j = charArray.Length - 1; i <= j; i++, j--)
            {
                if (charArray[i] == charArray[j])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
}
