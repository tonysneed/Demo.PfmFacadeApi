namespace PfmFacadeApi.Models.Pfm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ForecastWellRisk
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ForecastWellRiskId { get; set; }

        public int ScenarioWellId { get; set; }

        public double Oil { get; set; }

        public double Gas { get; set; }

        public double Water { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Created { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Updated { get; set; }

        [StringLength(100)]
        public string UpdatedBy { get; set; }

        public virtual ForecastHorizontal ForecastHorizontal { get; set; }

        //[ForeignKey("ScenarioWellId")]
        //public Cppe.ScenarioWell ScenarioWell { get; set; }
    }
}
