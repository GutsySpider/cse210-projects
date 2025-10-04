public class ListingActivity : Activity
{
    private int _count;
    
    private static List<string> _prompts = new List<string>
    {
        "List things you're grateful for.",
        "List people who inspire you.",
        "List goals you want to achieve."
    };
    private static List<string> _unusedPrompts = new List<string>(_prompts);

    public ListingActivity(int duration) : base("Listing Activity", "List as many things as you can about the prompt given.", duration)
    {
    
    }
    public override void Run()
    {
        DisplayStartingMessage();
        _duration = PromptForDuration();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);

        Console.WriteLine("Press enter when you are ready to begin.");
        Console.ReadLine();

        List<string> userList = GetListFromUser();
        Console.WriteLine($"You listed {_count} items in {_duration} seconds.");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }

        Random rand = new Random();
        int index = rand.Next(_unusedPrompts.Count);
        string selectedPrompt = _unusedPrompts[index];

        _unusedPrompts.RemoveAt(index);

        return selectedPrompt;
    }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        Console.WriteLine("Start Listing. Press enter after each item:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string answers = Console.ReadLine();
            responses.Add(answers);
        }
        _count = responses.Count;
        return responses;
    }
}