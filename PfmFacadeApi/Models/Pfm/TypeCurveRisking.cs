namespace PfmFacadeApi.Models.Pfm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeCurveRisking")]
    public partial class TypeCurveRisking
    {
        public int TypeCurveRiskingId { get; set; }

        public int TypeCurveId { get; set; }

        public int CaseId { get; set; }

        public decimal? Geo { get; set; }

        public decimal? Oil { get; set; }

        public decimal? Gas { get; set; }

        public decimal? Water { get; set; }

        [Required]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Updated { get; set; }

        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }
    }
}
