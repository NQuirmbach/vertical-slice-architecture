using Marten;

namespace BookingSystem.Infra;

public interface IFeature : IConfigureMarten
{
    static abstract void AddServices(IServiceCollection services, IConfiguration configuration);
}