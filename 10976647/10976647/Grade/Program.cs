using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade: ");
        string input = Console.ReadLine();
        int grade = Int32.Parse(input);

        if (grade >= 90 && grade <= 100)
        {
            Console.WriteLine("Grade: A");
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("Grade: B");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("Grade: C");
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("Grade: D");
        }
        else if (grade < 60 && grade >= 0)
        {
            Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("Invalid grade");
        }
    }
}