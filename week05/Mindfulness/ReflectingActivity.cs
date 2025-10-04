public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(int duration) :base("Reflecting Activity","Think deeply about the following prompts. ",duration)
    {
        _prompts = new List<string>
        {
            "Think of a time you overcame a challenge.",
            "Recall a moment of kindness you received.",
            "Reflect on a personal achievement."

        };
        _questions = new List<string>
        {
            "Why was this experience meaningful?",
            "What did you learn from it?",
            "How did it shape who you are today?"
        };

    }
    public override void Run()
    {
        DisplayStartingMessage();
        _duration = PromptForDuration();
        DisplayPrompt();

        ShowSpinner(3);

        DisplayQuestions();
        ShowSpinner(5);

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_prompts.Count);
        string randPrompt = _prompts[randomIndex];
        return randPrompt;
    }
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_questions.Count);
        string randQuestion = _questions[randomIndex];
        return randQuestion;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($" {prompt}");
        ShowSpinner(3);
    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($" {question}");
        ShowSpinner(5);
    }
}