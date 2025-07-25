using YouTubeVideos;

internal class Program
{
    private static void Main()
    {
        // ----- Vídeo 1 -----
        var v1 = new Video("Encapsulation in C#", "TechAcademy", 420);
        v1.AddComment(new Comment("Alice", "Great explanation, thanks!"));
        v1.AddComment(new Comment("Bob", "Could you talk about inheritance next?"));
        v1.AddComment(new Comment("Carlos", "Muito bom, aprendi bastante."));

        // ----- Vídeo 2 -----
        var v2 = new Video("BYU-I Pathway Tips", "Caio Mentor", 315);
        v2.AddComment(new Comment("Julia", "Essas dicas salvaram meu bloco!"));
        v2.AddComment(new Comment("Diego", "Como faço para mudar de gathering?"));
        v2.AddComment(new Comment("Marcos", "Obrigado, vídeo top!"));
        v2.AddComment(new Comment("Lana", "Fala também sobre bolsas, por favor."));

        // ----- Vídeo 3 -----
        var v3 = new Video("Top 5 Patterns in OOP", "CodeMaster", 600);
        v3.AddComment(new Comment("Zara", "Adapter pattern é o meu favorito!"));
        v3.AddComment(new Comment("Nate", "Please include examples in Java too."));
        v3.AddComment(new Comment("Rafa", "Muito claro, parabéns!"));

        // ----- Vídeo 4 (opcional) -----
        var v4 = new Video("LINQ Basics", "Dotnet Devs", 255);
        v4.AddComment(new Comment("Eve", "LINQ makes life easier!"));
        v4.AddComment(new Comment("Tom", "Where can I find more exercises?"));
        v4.AddComment(new Comment("Ana", "Excelente conteúdo, obrigada!"));

        var videos = new List<Video> { v1, v2, v3, v4 };

        // ----- Exibição -----
        foreach (var video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title:   {video.GetTitle()}");
            Console.WriteLine($"Author:  {video.GetAuthor()}");
            Console.WriteLine($"Length:  {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");

            foreach (var c in video.GetAllComments())
            {
                Console.WriteLine($"  - {c.GetAuthorName()}: {c.GetText()}");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
