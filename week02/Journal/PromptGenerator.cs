using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "If I could talk to my childhood self, I would tell them? ",
        "If you could have dinner with anyone (alive or dead), who would it be and why? ",
        "Write about a time you felt misunderstood. How did you handle it. ",
        "Think about a tradition that means a lot to you. ",
        "What did you accomplish today that you are proud of? ",
    };

    public List<string> _quotes = new List<string>
    {
        "“Successful journals break the deadlock of introspective obsession” — Alexandra Johnson",
        "“Write hard and clear about what hurts.” — Ernest Hemingway",
        "“The best time to begin keeping a journal is whenever you decide to.” — Hannah Hinchman",
        "The starting point of discovering who you are, your gifts, your talents, your dreams, is being comfortable with yourself. Spend time alone. Write in a journal.” — Robin Sharma",
        "What a comfort is this journal. I tell myself to myself and throw the burden on my book and feel relieved.” — Anne Lister,",
        "“Writing in a journal each day allows you to direct your focus to what you accomplished, what you’re grateful for and what you’re committed to doing better tomorrow. Thus, you more deeply enjoy your journey each day.” — Hal Elrod",
        "I am anxious, and it soothes me to express myself here. It is like whispering to one’s self and listening at the same time.” — Mina Murray’s journal entry from Bram Stoker’s Dracula"
    };

    public string GetRandomPrompt()
    {
        Random _random = new Random();

        string randomPrompt = _prompts[_random.Next(_prompts.Count)];

        return randomPrompt;

    }

    public string GetRandomQuote()
    {
        Random _random = new Random();

        string randomQuote = _quotes[_random.Next(_quotes.Count)];

        return randomQuote;

    }

}