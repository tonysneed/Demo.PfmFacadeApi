using Microsoft.OData.Edm;
using PfmFacadeApi.Models.Pfm;
using System.Web.Http;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace PfmFacadeApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapODataServiceRoute("odata", null, GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
            config.EnsureInitialized();
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.Namespace = "PfmFacadeApi";
            builder.ContainerName = "DefaultContainer";

            var forecastWellRisk = builder.EntitySet<ForecastWellRisk>(nameof(ForecastWellRisk));
            forecastWellRisk.EntityType.Property(e => e.Foo).AddedExplicitly = true;
            var bar = builder.EntitySet<Bar>(nameof(Bar));
            bar.EntityType.Property(e => e.Stuff).AddedExplicitly = true;

            var edmModel = builder.GetEdmModel();
            return edmModel;
        }
    }
}
