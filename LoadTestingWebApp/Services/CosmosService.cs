using LoadTestingWebApp.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;
using LoadTestingWebApp.Services;

namespace LoadTestingWebApp.Services;

public class CosmosService : ICosmosService
{
    private readonly CosmosClient _client;

    public CosmosService(IConfiguration config)
    {
        _client = new CosmosClient(
            connectionString: config.GetConnectionString("Cosmos")
        );
    }

    private Container Container
    {
        get => _client.GetDatabase("WebAppDB").GetContainer("Visits");
    }

    public async Task<IEnumerable<Visit>> RetrieveAllVisitsAsync()
    {
        var queryable = Container.GetItemLinqQueryable<Visit>();

        using FeedIterator<Visit> feed = queryable
            .OrderByDescending(v => v.dateTime)
            .ToFeedIterator();

        List<Visit> results = new();

        while (feed.HasMoreResults)
        {
            var response = await feed.ReadNextAsync();
            foreach (Visit item in response)
            {
                results.Add(item);
            }
        }

        return results;
    }

    public async Task AddVisitAsync(Visit _visit)
    {
        await Container.CreateItemAsync(_visit, new PartitionKey(_visit.id));
    }
}