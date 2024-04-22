namespace danscoconutsdotnet.Models;

public class Post(string title, string markdown, string slug)
{
  public int PostId { get; set; }
  public required string Title { get; set; } = title;
  public required string Markdown { get; set; } = markdown;
  public required string Slug { get; set; } = slug;
}
