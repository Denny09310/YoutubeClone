namespace YoutubeClone.Models;

public partial class Statistics
{
    public bool HiddenSubscriberCount { get; set; }
    public string SubscriberCount { get; set; } = null!;
    public string VideoCount { get; set; } = null!;
    public string ViewCount { get; set; } = null!;
}