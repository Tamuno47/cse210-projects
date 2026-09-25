using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Data Science Guide For Beginners", "Tamuno Godfrey", 600);

        Comment comment1 = new Comment("James Akpo", "Thanks for sharing this.");
        video1.AddComment(comment1);

        Comment comment2 = new Comment("Flourence Femi", "You made data science look easy.");
        video1.AddComment(comment2);

        Comment comment3 = new Comment("Dorcas Boma", "This is nice.");
        video1.AddComment(comment3);

        Comment comment4 = new Comment("Carlsen Joe", "The voiceover actual made this piece much more understandable, thanks for sharing.");
        video1.AddComment(comment4);


        Video video2 = new Video("Python For Beginners", "Ibinabo Samuel", 600);

        Comment comment5 = new Comment("Kingsley Anthony", "I recently started learning python, so i'm glad you shared this.");
        video2.AddComment(comment5);

        Comment comment6 = new Comment("Chioma David", "Python gets me confused at times but after this I think I will understand more.");
        video2.AddComment(comment6);

        Comment comment7 = new Comment("Simon Fubara", "Python seems interesting.");
        video2.AddComment(comment7);

        Comment comment8 = new Comment("Richard Monday", "This is very helpful, thanks for sharing.");
        video2.AddComment(comment8);


        Video video3 = new Video("Programming with Classes: Encapsulation", "Chris Felix", 600);

        Comment comment9 = new Comment("Raphel Johnson", "I think I'm getting to understand the basic principle of encapsulation now.");
        video3.AddComment(comment9);

        Comment comment10 = new Comment("Victor Ubong", "This is really nice.");
        video3.AddComment(comment10);

        Comment comment11 = new Comment("Justin Gbenga", "Thanks for sharing.");
        video3.AddComment(comment11);

        Comment comment12 = new Comment("Richard Monday", "This is a much better explanation for encapsulation, thank you.");
        video3.AddComment(comment12);


        Video video4 = new Video("Gain weight without over stressing yourself", "Chidinma Stephen", 600);

        Comment comment13 = new Comment("Janet Idowu", "Will I gain weight if I eat more quality food?");
        video4.AddComment(comment13);

        Comment comment14 = new Comment("Blessing Benjamin", "I will practice the eat early part.");
        video4.AddComment(comment14);

        Comment comment15 = new Comment("Sandra udeme", "I want to reduce my weight.");
        video4.AddComment(comment15);

        Comment comment16 = new Comment("Rejoice Christopher", "This is helpful.");
        video4.AddComment(comment16);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetComment());
                
            }

            Console.WriteLine();
        }


    }
}