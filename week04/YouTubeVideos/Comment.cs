using System;

public class Comment
{
    // Private fields
    private string _name;
    private string _text;

    // Public properties
    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public string Text
    {
        get { return _text; }
        private set { _text = value; }
    }

    // Constructor
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($" - {Name}: {Text}");
    }
}
