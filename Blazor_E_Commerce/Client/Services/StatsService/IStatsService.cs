namespace Blazor_E_Commerce.Client.Services.StatsService;

public interface IStatsService
{
    Task GetVisits();
    Task IncrementVisits();
}
