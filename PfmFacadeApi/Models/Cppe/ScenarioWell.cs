namespace PfmFacadeApi.Models.Cppe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ScenarioWell
    {
        [Key]
        public int ScenarioWellId { get; set; }

        public int ScenarioId { get; set; }

        public int? PadId { get; set; }

        public int WellId { get; set; }

        [Required]
        [StringLength(20)]
        public string Ssn { get; set; }

        public int? DrillOrder { get; set; }

        public int? RigId { get; set; }

        [Required]
        [StringLength(50)]
        public string Wellname { get; set; }

        public int? TankBatteryId { get; set; }

        public int? PadOrder { get; set; }

        public int? LateralLength { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdateTStamp { get; set; }

        [StringLength(50)]
        public string UpdateUID { get; set; }

        [StringLength(6)]
        public string TrainAfe { get; set; }

        public int? ArtificialLiftTypeId { get; set; }

        public int? PreferredArtificialLiftTypeId { get; set; }

        public int? BullpenClassificationId { get; set; }

        public int? CleanoutMethodId { get; set; }

        public bool? BatchProcess { get; set; }

        public bool WorkToAdvance { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AddedToBullpenTimeStamp { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BullpenUpdateTimeStamp { get; set; }

        public int? FracGroupId { get; set; }

        public int? DrilloutMethodId { get; set; }

        public bool JointVentureWell { get; set; }

        public int? StageCount { get; set; }

        public int? PlugBackTotalDepth { get; set; }

        public decimal? LandingPointTvd { get; set; }

        public int? GelWeightId { get; set; }

        public decimal? NetRevenueInterestPercent { get; set; }

        public decimal? OwnershipPercent { get; set; }

        public int? BullpenId { get; set; }

        public int? BullpenStatusId { get; set; }

        public bool IsManuallyIncludedWell { get; set; }

        public int DrillDesignId { get; set; }

        public int? BatchProcessTypeId { get; set; }

        [StringLength(50)]
        public string SysActionUID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WalkDate { get; set; }

        public int? StageLength { get; set; }

        public int? FluidSystemId { get; set; }

        public decimal? LinearGelPct { get; set; }

        public decimal? CrossLinkPct { get; set; }

        public decimal? SlickWaterPct { get; set; }

        public int? ClustersPerStage { get; set; }

        public int? StimEfficiency1 { get; set; }

        public int? StimEfficiency2 { get; set; }

        public int? StimEfficiency3 { get; set; }

        public int? FluidQuantity { get; set; }

        public decimal? ProppantPoundsPerFt { get; set; }

        public int? ProppantType1ItemId { get; set; }

        public decimal? ProppantType1Percent { get; set; }

        public int? ProppantType2ItemId { get; set; }

        public decimal? ProppantType2Percent { get; set; }

        public int? ProppantType3ItemId { get; set; }

        public decimal? ProppantType3Percent { get; set; }

        public int? ProppantType4ItemId { get; set; }

        public decimal? ProppantType4Percent { get; set; }

        public int? ProppantType5ItemId { get; set; }

        public decimal? ProppantType5Percent { get; set; }

        public double? WellRiskOil { get; set; }

        public double? WellRiskGas { get; set; }

        public double? WellRiskWater { get; set; }

        public int? CompletionDesignId { get; set; }

        public int? DrillGroupId { get; set; }

        public bool IsIncluded { get; set; }

        public int? TankBatteryAreaId { get; set; }

        public int? WaterDisposalSystemAreaId { get; set; }

        public bool HasSpudderRig { get; set; }

        public int? SpudderRigId { get; set; }

        public int? FracOrder { get; set; }

        public int? FracPadOrder { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Created { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Updated { get; set; }

        [StringLength(100)]
        public string UpdatedBy { get; set; }
    }
}
