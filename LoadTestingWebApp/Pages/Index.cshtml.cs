using Microsoft.AspNetCore.Mvc.RazorPages;
using LoadTestingWebApp.Models;
using LoadTestingWebApp.Services;

namespace LoadTestingWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ICosmosService _cosmosService;

        public IndexModel(ILogger<IndexModel> logger, ICosmosService cosmosService)
        {
            _logger = logger;
            _cosmosService = cosmosService;
        }

        public IEnumerable<Visit>? Visits { get; set; }

        public async Task OnGetAsync()
        {
            await _cosmosService.AddVisitAsync(new Visit(id: Guid.NewGuid().ToString(), dateTime: DateTime.Now));
            Visits ??= await _cosmosService.RetrieveAllVisitsAsync();
        }
    }
}