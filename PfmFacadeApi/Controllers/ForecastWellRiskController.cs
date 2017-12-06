using PfmFacadeApi.Data;
using System.Linq;
using System.Web.Http;
using System.Web.OData;

namespace PfmFacadeApi.Controllers
{
    [EnableQuery]
    public class ForecastWellRiskController : ODataController
    {
        public IHttpActionResult Get()
        {
            var query = DataSources.Instance.ForecastWellRisks.AsQueryable();
            return Ok(query);
        }
    }
}
