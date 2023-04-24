// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of words: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] words = new string[n];
        Console.WriteLine("Enter the words:");
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }
        string shortestword = words[0];
        for (int i = 1; i < n; i++)
        {
            if (words[i].Length < shortestword.Length)
            {
                shortestword = words[i];
            }
        }
        Console.WriteLine("The shortest word is: " + shortestword);
    }
}


