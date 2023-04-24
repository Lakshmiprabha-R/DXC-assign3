// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        List<string> words = new List<string> { "lilly", "orchid", "rose", "daisy", "jasmine" };
        words.Sort();
        Console.WriteLine("sorted words are:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}

