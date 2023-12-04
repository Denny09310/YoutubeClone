using Refit;

namespace YoutubeClone.Models.Queries;

public class ChannelDetailsQuery
{
    [AliasAs("part")]
    public string Part { get; set; } = "snippet,statistic";
}