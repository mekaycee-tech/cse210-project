using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create List to hold videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Tutorial for Beginners", "Tech Academy", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial, very clear!"));
        video1.AddComment(new Comment("Bob", "Thanks for explaining abstraction."));
        video1.AddComment(new Comment("Charlie", "This helped me pass my quiz."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("10 Minute Morning Stretch", "FitLife", 600);
        video2.AddComment(new Comment("David", "Felt great starting my day with this."));
        video2.AddComment(new Comment("Eva", "Simple and easy to follow routine."));
        video2.AddComment(new Comment("Frank", "My back feels so much better now."));
        video2.AddComment(new Comment("Grace", "Bookmarking this for tomorrow!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Easy Homemade Pizza Recipe", "Chef Maria", 900);
        video3.AddComment(new Comment("Hannah", "The crust turned out amazing."));
        video3.AddComment(new Comment("Ian", "Best pizza dough recipe on YouTube!"));
        video3.AddComment(new Comment("Julia", "My kids loved making this with me."));
        videos.Add(video3);

        // Iterate through list and display information
        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetName()}: \"{comment.GetText()}\"");
            }

            Console.WriteLine();
        }
    }
}