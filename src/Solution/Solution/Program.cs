using System;
using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        Console.WriteLine("=== Browser History ===");
        HistoryManager historyManager = new HistoryManager();
        historyManager.KunjungiHalaman("google.com");
        historyManager.KunjungiHalaman("example.com");

        Console.WriteLine("Current Page: " + historyManager.LihatHalamanSaatIni());
        Console.WriteLine("Going back to: " + historyManager.Kembali());
            
        historyManager.TampilkanHistory();
        Console.WriteLine();

        // Bracket validator
        Console.WriteLine("=== Bracket Validator ===");
        BracketValidator bracketValidator = new BracketValidator();
        string expression1 = "{[()]}";
        string expression2 = "{[(])}";
        Console.WriteLine($"Expression: {expression1} => Valid: {bracketValidator.ValidasiEkspresi(expression1)}");
        Console.WriteLine($"Expression: {expression2} => Valid: {bracketValidator.ValidasiEkspresi(expression2)}");
        Console.WriteLine();

        // Palindrome Checker
        Console.WriteLine("=== Palindrome Checker ===");
        string palindrome1 = "Kasur ini rusak";
        string palindrome2 = "Hello World";
        Console.WriteLine($"'{palindrome1}' is palindrome: {PalindromeChecker.CekPalindrom(palindrome1)}");
        Console.WriteLine($"'{palindrome2}' is palindrome: {PalindromeChecker.CekPalindrom(palindrome2)}");
    }
}
