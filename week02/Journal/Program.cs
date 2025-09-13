// Showing Creativity and Exceeding Requirements: I added an additional option to receive inspiration from a list of quotes surrounding journaling. I added another method to run the GetRandomQuote function. 

using System;
using System.IO;
using System.Data;
using System.Net.Quic;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;
        
        Journal theJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program");

        while (userInput !=6)
        {
            Console.WriteLine("1. Get inspiration \n2. Write a new entry \n3. Display the journal \n4. Save the journal \n5. Load the journal \n6. Quit");
            Console.Write("What would you like to do? ");
            string userAction = Console.ReadLine();
            userInput = int.Parse(userAction);

            if (userInput == 1)
            {
                PromptGenerator randomQuote = new PromptGenerator();
                string _quoteText = randomQuote.GetRandomQuote();
                Console.WriteLine(_quoteText);
            }

            else if (userInput == 2)
            {
                PromptGenerator randomPrompt = new PromptGenerator();
                string _promptText = randomPrompt.GetRandomPrompt();
                Console.WriteLine(_promptText);
                Console.Write("> ");
                string _entryText = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string _date = theCurrentTime.ToShortDateString();
                // Console.Write("What is the Date? ");
                // string _date = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._promptText = _promptText;
                newEntry._entryText = _entryText;
                newEntry._date = _date;

                theJournal.AddEntry(newEntry);



            }
            else if (userInput == 3)
            {
                theJournal.DisplayAll();
            }
            else if (userInput == 4)
            {
                Console.Write("Enter a file name: ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
            else if (userInput == 5)
            {

                Console.Write("Enter a file name: ");
                string file = Console.ReadLine();
                if (File.Exists(file))
                    theJournal.LoadFromFile(file);
                else
                    Console.WriteLine("File not found.");
            }
            else if (userInput == 6)
            {
                Console.WriteLine("Goodbye");
                userInput = 6;
            }
            else
            {
                Console.WriteLine("Incorrect option selected.");
            }
        
        }
    }
}