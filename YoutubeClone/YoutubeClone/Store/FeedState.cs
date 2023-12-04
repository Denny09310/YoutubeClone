using Fluxor;
using Refit;
using YoutubeClone.Http;
using YoutubeClone.Models.Results;

namespace YoutubeClone.Store;

[FeatureState]
public record FeedState
{
    public bool IsLoading { get; init; } = true;
    public string? ErrorMessage { get; init; }
    public ChannelVideosResult? ChannelVideos { get; init; }
}

public static class FeedReducer
{
    [ReducerMethod(typeof(FeedFetchDataAction))]
    public static FeedState OnFetchData(FeedState state)
    {
        return state with
        {
            IsLoading = true,
            ErrorMessage = null,
            ChannelVideos = null,
        };
    }

    [ReducerMethod]
    public static FeedState OnFetchDataFailure(FeedState state, FeedFetchFailureAction action)
    {
        return state with
        {
            IsLoading = false,
            ErrorMessage = action.ErrorMessage,
            ChannelVideos = null,
        };
    }

    [ReducerMethod]
    public static FeedState OnFetchDataSuccess(FeedState state, FeedFetchSuccessAction action)
    {
        return state with
        {
            IsLoading = false,
            ChannelVideos = action.Result
        };
    }
}

public class FeedEffects(IYoutubeClient client)
{
    [EffectMethod(typeof(FeedFetchDataAction))]
    public async Task FetchData(IDispatcher dispatcher)
    {
        try
        {
            var result = await client.GetChannelVideos("UCmXmlB4-HJytD7wek0Uo97A", new() { MaxResults = 25 });
            dispatcher.Dispatch(new FeedFetchSuccessAction(result));
        }
        catch (ApiException ex)
        {
            dispatcher.Dispatch(new FeedFetchFailureAction(ex.Message));
        }
    }
}

public record FeedFetchDataAction();
public record FeedFetchSuccessAction(ChannelVideosResult Result);
public record FeedFetchFailureAction(string ErrorMessage);