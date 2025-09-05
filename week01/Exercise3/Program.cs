using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the Magic Number? ");
        // string userMagic = Console.ReadLine();
        // int magicNumber = int.Parse(userMagic);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int magicGuess = -1;

        while (magicGuess != magicNumber)
        {
            Console.Write("What is your guess? (1-100) ");
            string userGuess = Console.ReadLine();
            magicGuess = int.Parse(userGuess);

            if (magicNumber > magicGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < magicGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}