//Stretch Created a varible called visibleWords to seperate words that have been hidden and words that have not been hidden yet. This keeps program from hiding the same words.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Moses", 1, 39);
        Scripture s1 = new Scripture(r1, "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
        

        while (true)
        {
            Console.Clear();
            Console.WriteLine(s1.GetDisplayText());

            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            s1.HideRandomWords(2);
                
            if (s1.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(s1.GetDisplayText());
                Console.WriteLine("All words are hidden. Program will now exit.");
                break;

            }
        }
    }
}

