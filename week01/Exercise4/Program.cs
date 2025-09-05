using System.Collections.Generic;

class Program
{
    static void Main(string[] args)


    {
        List<int> numbers = new List<int>();

        int enteredNumber = -1;

        while (enteredNumber != 0)
        {
            Console.Write("Enter Number (enter 0 to quit):");
            string userInput = Console.ReadLine();
            enteredNumber = int.Parse(userInput);

            if (enteredNumber != 0)
            {
                numbers.Add(enteredNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"Your sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Your average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"Your max is: {max}");
    }
}