
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
    [Table("ForecastTypes")]
    public partial class ForecastType
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ForecastType()
        {
             this.ForecastHorizontal_ForecastType = new HashSet<ForecastHorizontal>();  //FK_ForecastHorizontal_ForecastTypes
        AfterConstructor();
        }
    
        ///<summary>Provide the actual method AfterConstructor() in a partial class and it will get called as the last point in construction.</summary>
        partial void AfterConstructor();
    
            /// <summary></summary>
            [Key]
            
            
            public int ForecastTypeId { get; set; }
            /// <summary></summary>
            
            
            
            public string Description { get; set; }
            /// <summary></summary>
            
            
            
            public int? SortOrder { get; set; }
        /// <summary>FK_ForecastHorizontal_ForecastTypes</summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<ForecastHorizontal> ForecastHorizontal_ForecastType { get; set; }
            

    }
}