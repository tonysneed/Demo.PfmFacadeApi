namespace PfmFacadeApi.Models.Pfm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ForecastParameterDetail
    {
        public int ForecastParameterDetailId { get; set; }

        public int? ForecastParemeterId { get; set; }

        public double? StartDay { get; set; }

        public double? EndDay { get; set; }

        public int ForecastParamterProductTypeId { get; set; }

        public int ForecastSegmentTypeId { get; set; }

        public int? ForecastDeclineCurveTypeId { get; set; }

        public int? ForecastWellHeaderId { get; set; }

        public int? ForecastDurationOuomTypeId { get; set; }

        public decimal? Duration { get; set; }

        public decimal? InitialRate { get; set; }

        public decimal? InitialDecline { get; set; }

        public decimal? NFactor { get; set; }

        public decimal? FinalDecline { get; set; }

        public decimal? FinalRate { get; set; }

        public decimal? MinimumDecline { get; set; }

        public int? ForecastRatioCurveTypeId { get; set; }

        public int? ForecastRatioFluidTypeId { get; set; }

        public decimal? RatioInitialRate { get; set; }

        public decimal? RatioFinalRate { get; set; }

        public int? ForecastRatioVolumeOuomTypeId { get; set; }

        public string Remark { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Updated { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public int SegmentNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string SegmentId { get; set; }

        public bool IsActive { get; set; }

        public virtual ForecastDeclineCurveType ForecastDeclineCurveType { get; set; }

        public virtual ForecastDurationOuomType ForecastDurationOuomType { get; set; }

        public virtual ForecastParameter ForecastParameter { get; set; }

        public virtual ForecastParemeterProductType ForecastParemeterProductType { get; set; }

        public virtual ForecastRatioCurveType ForecastRatioCurveType { get; set; }

        public virtual ForecastRatioFluidType ForecastRatioFluidType { get; set; }

        public virtual ForecastRatioVolumeOuomType ForecastRatioVolumeOuomType { get; set; }

        public virtual ForecastSegmentType ForecastSegmentType { get; set; }
    }
}
