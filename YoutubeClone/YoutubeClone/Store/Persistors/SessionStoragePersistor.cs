using Blazored.SessionStorage;
using Fluxor.Persist.Storage;

namespace YoutubeClone.Store.Persistors;

public class SessionStoragePersistor(ISessionStorageService sessionStorage) : IStringStateStorage
{
    public ValueTask<string> GetStateJsonAsync(string statename)
    {
        return sessionStorage.GetItemAsStringAsync(statename);
    }

    public ValueTask StoreStateJsonAsync(string statename, string json)
    {
        return sessionStorage.SetItemAsStringAsync(statename, json);
    }
}