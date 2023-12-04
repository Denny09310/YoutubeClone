using Blazored.SessionStorage;
using Fluxor;
using Fluxor.Persist.Middleware;
using Fluxor.Persist.Storage;
using YoutubeClone.Store.Persistors;

namespace YoutubeClone.Extensions;

internal static class FluxorExtensions
{
    public static IServiceCollection RegisterFluxor(this IServiceCollection services)
    {
        services.AddBlazoredSessionStorage();

        services.AddScoped<IStringStateStorage, SessionStoragePersistor>();
        services.AddScoped<IStoreHandler, JsonStoreHandler>();

        return services.AddFluxor(opt =>
        {
            opt.ScanAssemblies(typeof(Program).Assembly);
            opt.UseReduxDevTools();
            opt.UsePersist();
        });
    }
}