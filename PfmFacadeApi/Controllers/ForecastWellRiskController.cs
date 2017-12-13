using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.OData;
using System.Web.OData.Query;
using PfmFacadeApi.Models.Pfm;
using Cppe = PfmFacadeApi.Models.Cppe;
using System.Net.Http;
using System.Web.Http;
using PfmFacadeApi.Utilities;

namespace PfmFacadeApi.Controllers
{
    public class ForecastWellRiskController : ODataController
    {
        private readonly PfmDb _context;
        private readonly HttpClient _cppeClient;
        private const string _cppeApiUri = "http://localhost/CppeDb.WebApi/api/";

        public ForecastWellRiskController()
        {
            _context = new PfmDb();
            _cppeClient = new HttpClient();
            _cppeClient.BaseAddress = new Uri(_cppeApiUri);
            _cppeClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        [EnableQuery]
        public async Task<IQueryable<ForecastWellRisk>> Get(ODataQueryOptions<ForecastWellRisk> opts)
        {
            // Get data from local database
            var list = await opts
                .ApplyTo(_context.ForecastWellRisks.AsQueryable())
                .ToListAsync();
            var result = list.Cast<ForecastWellRisk>().ToList();

            // Return if no data
            if (list.Count == 0)
                return result.AsQueryable();

            // Get data from Cppe Web API
            var ids = result
                .Select(e => e.ScenarioWellId)
                .ToArray();
            var filter = string.Join(" or ", ids.Select(i => $"(ScenarioWellId eq {i})"));
            var queryString = "ScenarioWells";
            if (filter.Length > 0)
                queryString += $"?$filter={filter}";

            HttpResponseMessage response = await _cppeClient.GetAsync(queryString);
            if (!response.IsSuccessStatusCode)
                throw new HttpResponseException(response.StatusCode);
            var content = await response.Content.ReadAsAsync<ODataResponse <Cppe.ScenarioWell>>();

            // Populate reference properties
            foreach (var item in result)
            {
                item.Foo = "foo";
                item.Bar = new Bar { Stuff = "bar" }; // Not serialized
                //item.ScenarioWell = content.Value.SingleOrDefault(e => e.ScenarioWellId == item.ScenarioWellId);
            }

            return result.AsQueryable();
        }
    }
}
