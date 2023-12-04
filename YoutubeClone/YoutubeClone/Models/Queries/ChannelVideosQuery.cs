using Refit;

namespace YoutubeClone.Models.Queries;

public class ChannelVideosQuery
{
    [AliasAs("maxResults")]
    public int MaxResults { get; set; } = 50;

    [AliasAs("order")]
    public string Order { get; set; } = "date";

    [AliasAs("part")]
    public string Part { get; set; } = "snippet,id";

    [AliasAs("regionCode")]
    public string RegionCode { get; set; } = "HK";
}