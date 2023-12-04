namespace YoutubeClone.Models.Results;

public class ChannelVideosResult
{
    public Item<ChannelVideoId>[] Items { get; set; } = [];
    public string Kind { get; set; } = null!;
    public PageInfo PageInfo { get; set; } = new();
}

public partial class ChannelVideoId
{
    public string Kind { get; set; } = null!;
    public string VideoId { get; set; } = null!;
}