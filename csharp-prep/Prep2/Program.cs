using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string grade = Console.ReadLine();

        int number = int.Parse(grade);
        string letter = " ";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80 && number < 90)
        {
            letter = "B";
        }
        else if (number >= 70 && number < 80)
        {
            letter = "C";
        }
        else if (number >= 60 && number < 70)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is a(n) {letter}");
        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You failed! Try again, you'll do better next time.");
        }
    }
}