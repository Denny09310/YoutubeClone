namespace YoutubeClone.Models.Results;

public partial class ChannelDetailsResult
{
    public Item<string>[] Items { get; set; } = [];
    public string Kind { get; set; } = null!;
    public PageInfo PageInfo { get; set; } = new();
}