namespace PfmFacadeApi.Models.Pfm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ForecastHorizontalBaseDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ForecastHorizontalBaseDetailId { get; set; }

        public int ForecastHorizontalBaseId { get; set; }

        [Required]
        [StringLength(50)]
        public string Pdp { get; set; }

        public int DaysOn { get; set; }

        public double UnriskedOil { get; set; }

        public double UnriskedGas { get; set; }

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

        [Column(TypeName = "datetime2")]
        public DateTime? Created { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Updated { get; set; }

        [StringLength(100)]
        public string UpdatedBy { get; set; }

        public virtual ForecastHorizontalBase ForecastHorizontalBase { get; set; }
    }
}
