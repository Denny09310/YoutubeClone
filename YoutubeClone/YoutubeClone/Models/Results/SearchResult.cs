namespace YoutubeClone.Models.Results;

public partial class SearchResult
{
    public Item<SearchId>[] Items { get; set; } = [];
    public string Kind { get; set; } = null!;
    public string NextPageToken { get; set; } = null!;
    public PageInfo PageInfo { get; set; } = new();
    public string RegionCode { get; set; } = null!;
}

public partial class SearchId
{
    public string Kind { get; set; } = null!;
    public string VideoId { get; set; } = null!;
}