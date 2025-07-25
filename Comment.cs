namespace YouTubeVideos;

public class Comment
{
    private string _authorName;
    private string _text;

    public Comment(string authorName, string text)
    {
        _authorName = authorName;
        _text = text;
    }

    public string GetAuthorName() => _authorName;
    public string GetText() => _text;

    public override string ToString() => $"{_authorName}: {_text}";
}
