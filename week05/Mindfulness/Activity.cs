public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
    public virtual void Run()
    {
        
    }

    public static int PromptForDuration()
    {
        Console.Write("Enter in seconds how long you would like to do this exercise? ");
        int duration = int.Parse(Console.ReadLine());
        return duration;
    }
            public static void ShowMenu()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Activity Menu ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option (1–4): ");

            string choice = Console.ReadLine();
            Activity activity = null;


            if (choice == "1")
            {
                activity = new BreathingActivity(0);
            }
            else if (choice == "2")
            {
                activity = new ListingActivity(0);
            }
            else if (choice == "3")
            {
                activity = new ReflectingActivity(0);
            }
            else if (choice == "4")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                Console.WriteLine("Press Enter to try again...");
                Console.ReadLine();
                continue;
            }
            if (activity != null)
            {
                Console.Clear();
                activity.Run(); 
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}