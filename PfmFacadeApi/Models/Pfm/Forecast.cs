namespace PfmFacadeApi.Models.Pfm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Forecast
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Forecast()
        {
            ForecastHorizontals = new HashSet<ForecastHorizontal>();
            ForecastVerticals = new HashSet<ForecastVertical>();
        }

        public int ForecastId { get; set; }

        public int ScenarioId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Updated { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForecastHorizontal> ForecastHorizontals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForecastVertical> ForecastVerticals { get; set; }
    }
}
