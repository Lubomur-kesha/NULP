namespace Lab6_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class countries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public countries()
        {
            cities = new HashSet<cities>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int country_id { get; set; }

        [Key]
        [StringLength(50)]
        public string country { get; set; }

        [Required]
        [StringLength(50)]
        public string restorant_chain { get; set; }

        public int area_km_kv { get; set; }

        [Required]
        [StringLength(50)]
        public string president { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cities> cities { get; set; }

        public virtual Restorants_chain Restorants_chain { get; set; }
    }
}
