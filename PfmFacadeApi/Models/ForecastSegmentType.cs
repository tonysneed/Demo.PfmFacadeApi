
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
    [Table("ForecastSegmentTypes")]
    public partial class ForecastSegmentType
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ForecastSegmentType()
        {
             this.ForecastParameterDetails_ForecastSegmentType = new HashSet<ForecastParameterDetail>();  //FK_ForecastParameters_ForecastSegmentTypes
             //this.TypeCurveParameters_ForecastSegmentType = new HashSet<TypeCurveParameter>();  //FK_TypecurveParameters_ForecastSegmentTypes
        AfterConstructor();
        }
    
        ///<summary>Provide the actual method AfterConstructor() in a partial class and it will get called as the last point in construction.</summary>
        partial void AfterConstructor();
    
            /// <summary></summary>
            [Key]
            
            
            public int ForecastSegmentTypeId { get; set; }
            /// <summary></summary>
            
            
            
            public string Name { get; set; }
        /// <summary>FK_ForecastParameters_ForecastSegmentTypes</summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<ForecastParameterDetail> ForecastParameterDetails_ForecastSegmentType { get; set; }
            
        /// <summary>FK_TypecurveParameters_ForecastSegmentTypes</summary> 
         //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         //public virtual ICollection<TypeCurveParameter> TypeCurveParameters_ForecastSegmentType { get; set; }
            

    }
}
