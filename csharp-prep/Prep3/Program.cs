using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        //Console.Write("What is your the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}