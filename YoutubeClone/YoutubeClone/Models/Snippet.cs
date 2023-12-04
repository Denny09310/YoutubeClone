namespace YoutubeClone.Models;

public partial class Snippet
{
    public string Country { get; set; } = null!;
    public string CustomUrl { get; set; } = null!;
    public string Description { get; set; } = null!;
    public Localized Localized { get; set; } = default!;
    public DateTimeOffset PublishedAt { get; set; }
    public Thumbnails Thumbnails { get; set; } = default!;
    public string Title { get; set; } = null!;
    public string ChannelTitle { get; set; } = default!;
}
