using System;
using System.Collections.Generic;

public class Video
{
    // Private fields
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    // Public properties
    public string Title
    {
        get { return _title; }
        private set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        private set { _author = value; }
    }

    public int Length
    {
        get { return _length; }
        private set { _length = value; }
    }

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    // Methods
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");

        foreach (var comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}
