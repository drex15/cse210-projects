using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Basics", "TechTutor", 600);
        Video video2 = new Video("OOP Explained", "CodeMaster", 720);
        Video video3 = new Video("Abstraction in Action", "DevWorld", 540);

        // Add 4 comments each
        video1.AddComment(new Comment("Alice", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Bob", "Clear explanation."));
        video1.AddComment(new Comment("Charlie", "Loved the examples."));
        video1.AddComment(new Comment("Daisy", "I learned a lot!"));

        video2.AddComment(new Comment("Diana", "Now I finally get OOP."));
        video2.AddComment(new Comment("Ethan", "Please make a follow-up."));
        video2.AddComment(new Comment("Fiona", "So useful!"));
        video2.AddComment(new Comment("Henry", "This saved me for my exam."));

        video3.AddComment(new Comment("George", "Abstraction makes sense now."));
        video3.AddComment(new Comment("Hannah", "Great teaching style."));
        video3.AddComment(new Comment("Ian", "I’ll recommend this to my friends."));
        video3.AddComment(new Comment("Jane", "Clear and easy to follow."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video info
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
