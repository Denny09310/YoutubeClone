using Fluxor;

namespace YoutubeClone.Store;

[FeatureState]
public record SidebarState
{
    public bool IsOpen { get; init; }
}

public static class SidebarReducer
{
    [ReducerMethod]
    public static SidebarState OnSetIsOpen(SidebarState state, SidebarSetIsOpenAction action)
    {
        return state with
        {
            IsOpen = action.IsOpen,
        };
    }

    [ReducerMethod(typeof(SidebarToggleIsOpenAction))]
    public static SidebarState OnToggleIsOpen(SidebarState state)
    {
        return state with
        {
            IsOpen = !state.IsOpen,
        };
    }
}

public record SidebarToggleIsOpenAction();
public record SidebarSetIsOpenAction(bool IsOpen);