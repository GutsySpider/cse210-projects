using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(name, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userInput = Console.ReadLine();
            int favoriteNumber = int.Parse(userInput);
            return favoriteNumber;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int squaredNumber = favoriteNumber * favoriteNumber;
            return squaredNumber;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}. the square of your number is {squaredNumber}");
        }
    }
}