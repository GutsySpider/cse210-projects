using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = Video.CreateVideo("Leonard", "Jubilie", 120);
        v1.AddComment(new Comment("Megazord", "Great vibe I can't wait for the next video."));
        v1.AddComment(new Comment("Piny67", "How do you do that?"));
        v1.AddComment(new Comment("MonotoneDon", "More COWBELL!"));
        v1.AddComment(new Comment("SadPanda", "This is Horrible!"));



        Video v2 = Video.CreateVideo("How to make a PB&J", "EZTutorials", 180);
        v2.AddComment(new Comment("Deral", "What is you favorite Jam?"));
        v2.AddComment(new Comment("Steel45", "Ever used mayo?"));
        v2.AddComment(new Comment("sandwitch", "Who taught you how to make that?"));
        v2.AddComment(new Comment("Tonytimber", "Looks like a great Lunch to me."));



        Video v3 = Video.CreateVideo("Hike to the lake.", "OutdoorTime", 480);
        v3.AddComment(new Comment("Carry1", "Long Hike"));
        v3.AddComment(new Comment("Oxford", "Beautiful views."));
        v3.AddComment(new Comment("Blatinbe", "Do you have the trail information?"));
        v3.AddComment(new Comment("Brightlite", "Any good fishing spots?"));

        foreach (Video video in Video.GetVideos())
        {
            Console.WriteLine(video.Display());
            video.CommentAmount();
            video.DisplayComments();
        }
    }
}