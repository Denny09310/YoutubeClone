using Fluxor;

namespace YoutubeClone.Extensions;

internal static class FluxorExtensions
{
    public static IServiceCollection RegisterFluxor(this IServiceCollection services)
    {
        return services.AddFluxor(opt =>
        {
            opt.ScanAssemblies(typeof(Program).Assembly);
            opt.UseReduxDevTools();
        });
    }
}