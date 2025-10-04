public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.", duration)
    {
     
    }
    public override void Run()
    {
        DisplayStartingMessage();
        _duration = PromptForDuration();
        Console.WriteLine("Prepare to begin.");
        ShowCountDown(8);
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in");
            ShowCountDown(5);
            Console.WriteLine("Breathe out");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
        
    }
}