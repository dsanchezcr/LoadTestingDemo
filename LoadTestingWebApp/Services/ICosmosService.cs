using LoadTestingWebApp.Models;

namespace LoadTestingWebApp.Services;

public interface ICosmosService
{
    Task<IEnumerable<Visit>> RetrieveAllVisitsAsync();
    Task AddVisitAsync(Visit _visit);
}