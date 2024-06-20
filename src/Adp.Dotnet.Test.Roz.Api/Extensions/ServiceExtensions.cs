using Adp.Dotnet.Test.Roz.Core.Interfaces;
using Adp.Dotnet.Test.Roz.Core.Services;

namespace Adp.Dotnet.Test.Roz.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
