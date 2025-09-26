using System;
using System.Globalization;

public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();
    private static List<Video> _videos = new List<Video>();

    private Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public static Video CreateVideo(string title, string author, int length)
    {
        Video v = new Video(title, author, length);
        _videos.Add(v);
        return v;
    }
    public static List<Video> GetVideos()
    {
        return new List<Video>(_videos);
    }
    public void CommentAmount()
    {

        Console.WriteLine($"Number of Comments: {_comments.Count()}\n");

    }

    public Video AddComment(Comment comment)
    {
        _comments.Add(comment);
        return new Video(_title, _author, _length) { _comments = _comments };

    }
    public string Display()
    {
        return $"Title: {_title} Author: {_author} Length: {_length}";
    }

    public void DisplayComments()
    {
        
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.Display());
            Console.WriteLine();
        }
    }
}