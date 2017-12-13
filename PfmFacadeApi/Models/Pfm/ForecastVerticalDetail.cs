namespace PfmFacadeApi.Models.Pfm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ForecastVerticalDetail
    {
        public int ForecastVerticalDetailId { get; set; }

        public int ForecastVerticalId { get; set; }

        public double? CopasCoop { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Date { get; set; }

        public double? DevDrill { get; set; }

        public double? ExplCompl { get; set; }

        public double? ExplDrill { get; set; }

        public double? Facilities { get; set; }

        [Required]
        [StringLength(50)]
        public string CaseId { get; set; }

        public double? Ffg { get; set; }

        public double? Frac { get; set; }

        public double? GrossBoe { get; set; }

        public double? GrossCondensate { get; set; }

        public double? GrossGas { get; set; }

        public double? GrossMboed { get; set; }

        public double? GrossMcfe { get; set; }

        public double? GrossMmcfed { get; set; }

        public double? GrossNgl { get; set; }

        public double? GrossOil { get; set; }

        public double? GrossWater { get; set; }

        public double? Land { get; set; }

        public double? Loe { get; set; }

        public double? NetBoe { get; set; }

        public double? NetCondensate { get; set; }

        public double? NetGas { get; set; }

        public double? NetMboed { get; set; }

        public double? NetMcfe { get; set; }

        public double? NetMmcfed { get; set; }

        public double? NetNgl { get; set; }

        public double? NetOil { get; set; }

        public double? NetWater { get; set; }

        public double? Ngp { get; set; }

        public double? PopWells { get; set; }

        [StringLength(50)]
        public string Quarter { get; set; }

        public double? RigCount { get; set; }

        public double? Seismic { get; set; }

        public double? Spud { get; set; }

        public double? Workover { get; set; }

        public int? Year { get; set; }

        [Required]
        [StringLength(50)]
        public string Pdp { get; set; }

        public int WellId { get; set; }

        public int DaysOn { get; set; }

        public double UnriskedOil { get; set; }

        public double? UnriskedGas { get; set; }

        public double UnriskedWater { get; set; }

        public double OilBopd { get; set; }

        public double GasMcfpd { get; set; }

        public double DryGasMcfpd { get; set; }

        public double NglBpd { get; set; }

        public double WaterBpd { get; set; }

        public double Gross2StreamBoe { get; set; }

        public double Gross3StreamBoe { get; set; }

        public double NetOilVolumeBpd { get; set; }

        public double NetWetGasVolumeMcfpd { get; set; }

        public double NetDryGasVolumeMcfpd { get; set; }

        public double NetNglBpd { get; set; }

        public double Net2StreamBoe { get; set; }

        public double Net3StreamBoe { get; set; }

        public double? NetJvOilVolumeBpd { get; set; }

        public double? NetJvWetGasVolumeMcfpd { get; set; }

        public double? NetJvDryGasVolumeMcfpd { get; set; }

        public double? NetJvNglBpd { get; set; }

        public double? NetJv2StreamBoe { get; set; }

        public double? NetJv3StreamBoe { get; set; }

        public int? DivisionId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Created { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Updated { get; set; }

        [StringLength(100)]
        public string UpdatedBy { get; set; }

        public virtual ForecastVertical ForecastVertical { get; set; }
    }
}
