
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video(
            "Learn C# Programming",
            "John Smith",
            600
        );

        video1.AddComment(new Comment("Maria", "Great video!"));
        video1.AddComment(new Comment("David", "I learned something new."));
        video1.AddComment(new Comment("Ana", "Thank you for sharing."));
        video1.AddComment(new Comment("Carlos", "Very helpful lesson."));

        // Create the second video
        Video video2 = new Video(
            "Introduction to Python",
            "Sarah Johnson",
            480
        );

        video2.AddComment(new Comment("Luis", "I love Python."));
        video2.AddComment(new Comment("Emma", "Very easy to understand."));
        video2.AddComment(new Comment("Pedro", "Good explanation."));
        video2.AddComment(new Comment("Sofia", "Thanks for this tutorial."));

        // Create the third video
        Video video3 = new Video(
            "How to Create a Website",
            "Michael Brown",
            720
        );

        video3.AddComment(new Comment("Laura", "This helped me a lot."));
        video3.AddComment(new Comment("Daniel", "Great tutorial."));
        video3.AddComment(new Comment("Andrea", "I want more videos like this."));
        video3.AddComment(new Comment("Kevin", "Very interesting."));

        // Store all videos in a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("==============================");
            video.DisplayVideoInformation();
            Console.WriteLine();
        }
    }
}
