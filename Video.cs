namespace YouTubeVideos;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private readonly List<Comment> _comments = new();

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public int GetLengthSeconds() => _lengthSeconds;

    public void AddComment(Comment comment) => _comments.Add(comment);

    public int GetCommentCount() => _comments.Count;

    public IEnumerable<Comment> GetAllComments() => _comments;
}
