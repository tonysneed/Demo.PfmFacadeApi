namespace PfmFacadeApi.Models.Pfm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForecastParameter")]
    public partial class ForecastParameter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ForecastParameter()
        {
            ForecastParameterDetails = new HashSet<ForecastParameterDetail>();
        }

        public int ForecastParameterId { get; set; }

        public int? CaseId { get; set; }

        public int WellId { get; set; }

        public int AssetTeamId { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EffectiveDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime WalkDate { get; set; }

        public int? ForecastHorizontalId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Created { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Updated { get; set; }

        [StringLength(100)]
        public string UpdatedBy { get; set; }

        public virtual ForecastHorizontal ForecastHorizontal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForecastParameterDetail> ForecastParameterDetails { get; set; }
    }
}
