using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age = Int32.Parse(input);

        if (age >= 65 || age <= 12)
        {
            Console.WriteLine("Your ticket price is GHC7.");
        }
        else
        {
            Console.WriteLine("Your ticket price is GHC10.");
        }
    }
}