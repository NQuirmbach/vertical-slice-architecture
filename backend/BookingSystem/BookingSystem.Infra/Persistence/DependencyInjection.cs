using BookingSystem.Infra.Persistence.Exceptions;
using Marten;
using Weasel.Core;

namespace BookingSystem.Infra.Persistence;

public static class DependencyInjection
{
    public static void ConfigureMarten(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database");
        
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new NoConnectionStringException();
        
        services.AddMarten(options =>
        {
            options.Connection(connectionString);

            options.AutoCreateSchemaObjects = AutoCreate.All;
            RegisterFeatures(options);
        })
        .UseLightweightSessions();
    }

    private static void RegisterFeatures(StoreOptions options)
    {
        
    }
}