using PfmFacadeApi.Models.Cppe;
using System.ComponentModel.DataAnnotations.Schema;

namespace PfmFacadeApi.Models.Pfm
{
    public partial class ForecastWellRisk
    {
        //[NotMapped]
        //[ForeignKey("ScenarioWellId")]
        //public ScenarioWell ScenarioWell { get; set; }

        [NotMapped]
        public string Foo { get; set; }

        [NotMapped]
        public Bar Bar { get; set; }
    }
}
