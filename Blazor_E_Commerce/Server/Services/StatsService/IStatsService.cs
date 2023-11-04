namespace Blazor_E_Commerce.Server.Services.StatsService;

public interface IStatsService
{
    Task<int> GetVisits();
    Task IncrementVisits();
}
