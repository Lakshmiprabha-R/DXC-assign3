// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        string[] words = { "malayalam", "hello", "level", "world", "noon" };
        int count = 0;
        string[] palindromeWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            if (IsPalindrome(words[i]))
            {
                palindromeWords[count] = words[i];
                count++;
            }
        }
        Console.WriteLine("Palindrome words are: " + count);
        Console.Write("List of Palindrome words: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(palindromeWords[i] + " ");
        }
    }

    static bool IsPalindrome(string word)
    {
        int length = word.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
