using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.Palindrome
{
    public class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            Stack<char> stack = new Stack<char>();
            List<char> filteredChars = new List<char>();

            foreach (char ch in input.ToLower())
            {
                if (char.IsLetterOrDigit(ch))
                {
                    stack.Push(ch);
                    filteredChars.Add(ch);
                }
            }

            foreach (char ch in filteredChars)
            {
                if (stack.Pop() != ch)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
