using Fluxor;
using Refit;
using YoutubeClone.Http;
using YoutubeClone.Models.Results;

namespace YoutubeClone.Store;

[FeatureState]
public record SearchState
{
    public string? Query { get; init; }
    public string? ErrorMessage { get; init; }
    public bool IsLoading { get; init; }
    public SearchResult? Result { get; init; }
}

public static class SearchReducer
{
    [ReducerMethod]
    public static SearchState OnFetchResult(SearchState state, SearchFetchResultAction action)
    {
        return state with
        {
            IsLoading = true,
            Query = action.Query,
            ErrorMessage = string.Empty,
        };
    }

    [ReducerMethod]
    public static SearchState OnFetchResultFail(SearchState state, SearchFetchResultFailAction action)
    {
        return state with
        {
            IsLoading = false,
            ErrorMessage = action.ErrorMessage,
        };
    }

    [ReducerMethod]
    public static SearchState OnFetchResultSuccess(SearchState state, SearchFetchResultSuccessAction action)
    {
        return state with
        {
            IsLoading = false,
            Result = action.Result,
        };
    }
}

public class SearchEffects(IYoutubeClient client)
{
    [EffectMethod]
    public async Task PerformSearch(SearchFetchResultAction action, IDispatcher dispatcher)
    {
        if (string.IsNullOrEmpty(action.Query))
        {
            return;
        }

        try
        {
            var result = await client.Search(action.Query, new());
            dispatcher.Dispatch(new SearchFetchResultSuccessAction(result));
        }
        catch (ApiException ex)
        {
            dispatcher.Dispatch(new SearchFetchResultFailAction(ex.Message));
        }
    }
}

public record SearchFetchResultAction(string Query);
public record SearchFetchResultSuccessAction(SearchResult Result);
public record SearchFetchResultFailAction(string ErrorMessage);