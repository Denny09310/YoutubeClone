namespace YoutubeClone.Models;

public partial class Item<T>
{
    public BrandingSettings? BrandingSettings { get; set; }
    public ContentDetails? ContentDetails { get; set; }
    public T Id { get; set; } = default!;
    public string Kind { get; set; } = null!;
    public Snippet? Snippet { get; set; }
    public Statistics? Statistics { get; set; }
}