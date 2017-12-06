
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace CppeDb.DataAccess.Models
{
    /// <summary></summary>
    [Table("ForecastVerticalDetails")]
    public partial class ForecastVerticalDetail
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ForecastVerticalDetail()
        {
        AfterConstructor();
        }
    
        ///<summary>Provide the actual method AfterConstructor() in a partial class and it will get called as the last point in construction.</summary>
        partial void AfterConstructor();
    
            /// <summary></summary>
            [Key]
            
            
            public int ForecastVerticalDetailId { get; set; }
            /// <summary></summary>
            
            
            
            public int ForecastVerticalId { get; set; }
            /// <summary></summary>
            
            
            
            public double? CopasCoop { get; set; }
            /// <summary></summary>
            
            
            
            public DateTime? Date { get; set; }
            /// <summary></summary>
            
            
            
            public double? DevDrill { get; set; }
            /// <summary></summary>
            
            
            
            public double? ExplCompl { get; set; }
            /// <summary></summary>
            
            
            
            public double? ExplDrill { get; set; }
            /// <summary></summary>
            
            
            
            public double? Facilities { get; set; }
            /// <summary></summary>
            
            
            
            public string CaseId { get; set; }
            /// <summary></summary>
            
            
            
            public double? Ffg { get; set; }
            /// <summary></summary>
            
            
            
            public double? Frac { get; set; }
            /// <summary></summary>
            
            
            
            public double? GrossBoe { get; set; }
            /// <summary></summary>
            
            
            
            public double? GrossCondensate { get; set; }
            /// <summary></summary>
            
            
            
            public double? GrossGas { get; set; }
            /// <summary></summary>
            
            
            
            public double? GrossMboed { get; set; }
            /// <summary></summary>
            
            
            
            public double? GrossMcfe { get; set; }
            /// <summary></summary>
            
            
            
            public double? GrossMmcfed { get; set; }
            /// <summary></summary>
            
            
            
            public double? GrossNgl { get; set; }
            /// <summary></summary>
            
            
            
            public double? GrossOil { get; set; }
            /// <summary></summary>
            
            
            
            public double? GrossWater { get; set; }
            /// <summary></summary>
            
            
            
            public double? Land { get; set; }
            /// <summary></summary>
            
            
            
            public double? Loe { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetBoe { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetCondensate { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetGas { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetMboed { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetMcfe { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetMmcfed { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetNgl { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetOil { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetWater { get; set; }
            /// <summary></summary>
            
            
            
            public double? Ngp { get; set; }
            /// <summary></summary>
            
            
            
            public double? PopWells { get; set; }
            /// <summary></summary>
            
            
            
            public string Quarter { get; set; }
            /// <summary></summary>
            
            
            
            public double? RigCount { get; set; }
            /// <summary></summary>
            
            
            
            public double? Seismic { get; set; }
            /// <summary></summary>
            
            
            
            public double? Spud { get; set; }
            /// <summary></summary>
            
            
            
            public double? Workover { get; set; }
            /// <summary></summary>
            
            
            
            public int? Year { get; set; }
            /// <summary></summary>
            
            
            
            public string Pdp { get; set; }
            /// <summary></summary>
            
            
            
            public int WellId { get; set; }
            /// <summary></summary>
            
            
            
            public int DaysOn { get; set; }
            /// <summary></summary>
            
            
            
            public double UnriskedOil { get; set; }
            /// <summary></summary>
            
            
            
            public double? UnriskedGas { get; set; }
            /// <summary></summary>
            
            
            
            public double UnriskedWater { get; set; }
            /// <summary></summary>
            
            
            
            public double OilBopd { get; set; }
            /// <summary></summary>
            
            
            
            public double GasMcfpd { get; set; }
            /// <summary></summary>
            
            
            
            public double DryGasMcfpd { get; set; }
            /// <summary></summary>
            
            
            
            public double NglBpd { get; set; }
            /// <summary></summary>
            
            
            
            public double WaterBpd { get; set; }
            /// <summary></summary>
            
            
            
            public double Gross2StreamBoe { get; set; }
            /// <summary></summary>
            
            
            
            public double Gross3StreamBoe { get; set; }
            /// <summary></summary>
            
            
            
            public double NetOilVolumeBpd { get; set; }
            /// <summary></summary>
            
            
            
            public double NetWetGasVolumeMcfpd { get; set; }
            /// <summary></summary>
            
            
            
            public double NetDryGasVolumeMcfpd { get; set; }
            /// <summary></summary>
            
            
            
            public double NetNglBpd { get; set; }
            /// <summary></summary>
            
            
            
            public double Net2StreamBoe { get; set; }
            /// <summary></summary>
            
            
            
            public double Net3StreamBoe { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetJvOilVolumeBpd { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetJvWetGasVolumeMcfpd { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetJvDryGasVolumeMcfpd { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetJvNglBpd { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetJv2StreamBoe { get; set; }
            /// <summary></summary>
            
            
            
            public double? NetJv3StreamBoe { get; set; }
            /// <summary></summary>
            
            
            
            public int? DivisionId { get; set; }
        /// <summary>FK_ForecastVerticalDetails_Divisions</summary>
        //[ForeignKey("DivisionId")]
        //public virtual Division Division { get; set; }
        /// <summary>FK_ForecastVerticalDetails_ForecastVerticals</summary>
        [ForeignKey("ForecastVerticalId")]
        public virtual ForecastVertical ForecastVertical { get; set; }

    }
}