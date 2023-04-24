// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "vanilla", "chocolate", "berry", "candy", "mango" };
        Console.Write("Enter a word to check: ");
        string input = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == input)
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine("The word is present in the list.");
        }
        else 
        {
            Console.WriteLine("The word is not present in the list.");
        }
    }

}




