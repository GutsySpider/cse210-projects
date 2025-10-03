public class ListingActivity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int count, List<string> prompts)
    {
        _count = count;
        _prompts = prompts;
    }
    public void Run()
    {

    }
    public void GetRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        return new List<string> (_prompts);
    }
}