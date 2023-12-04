namespace YoutubeClone.Client.Store;

public abstract class ApplicationState
{
    public event Action? OnChanged;

    public void NotifyStateChanged() => OnChanged?.Invoke();
}