using Refit;
using YoutubeClone.Models.Queries;
using YoutubeClone.Models.Results;

namespace YoutubeClone.Http;

public interface IYoutubeClient
{
    [Get("/channels")]
    Task<ChannelDetailsResult> GetChannelDetails([AliasAs("id")] string channelId, ChannelDetailsQuery additionalParameters);

    [Get("/search")]
    Task<ChannelVideosResult> GetChannelVideos(string channelId, ChannelVideosQuery additionalParameters);

    [Get("/search")]
    Task<SearchResult> Search([AliasAs("q")] string query, SearchQuery additionalParameters);
}