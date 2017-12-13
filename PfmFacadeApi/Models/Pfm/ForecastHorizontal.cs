namespace PfmFacadeApi.Models.Pfm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForecastHorizontal")]
    public partial class ForecastHorizontal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ForecastHorizontal()
        {
            ForecastHorizontalDetails = new HashSet<ForecastHorizontalDetail>();
            ForecastParameters = new HashSet<ForecastParameter>();
            ForecastSeasonalRisks = new HashSet<ForecastSeasonalRisk>();
        }

        public int ForecastHorizontalId { get; set; }

        public int ForecastId { get; set; }

        public int? ForecastTypeId { get; set; }

        public int? OutputRateId { get; set; }

        public int? ProvenDevelopedProducingDatasetId { get; set; }

        public int? GasCalculationId { get; set; }

        public int? InitialFlowRateQiId { get; set; }

        public int? InitialFlowRateQiMax { get; set; }

        public int? InitialOilRampTypeId { get; set; }

        public int? InitialGasRampTypeId { get; set; }

        public int? ShutinOilRampTypeId { get; set; }

        public int? ShutinGasRampTypeId { get; set; }

        public bool? IncludeSi { get; set; }

        public decimal? SiMergeBufferNumberOfDays { get; set; }

        public bool? GlobalTerminalDecline { get; set; }

        public decimal? TerminalOilDecline { get; set; }

        public decimal? TerminalGasDecline { get; set; }

        public int? MinimumPlugAndAbandonRate { get; set; }

        public int? UnitId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsApproved { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Updated { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual ForecastGlobalRisk ForecastGlobalRisk { get; set; }

        public virtual Forecast Forecast { get; set; }

        public virtual ForecastType ForecastType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForecastHorizontalDetail> ForecastHorizontalDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForecastParameter> ForecastParameters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForecastSeasonalRisk> ForecastSeasonalRisks { get; set; }

        public virtual ForecastWellRisk ForecastWellRisk { get; set; }
    }
}
