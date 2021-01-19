namespace Lab6_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Restorants_chain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Restorants_chain()
        {
            countries = new HashSet<countries>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int restorant_chain_id { get; set; }

        [Key]
        [StringLength(50)]
        public string restorant_chain { get; set; }

        [Required]
        [StringLength(50)]
        public string country { get; set; }

        public int date_of_creation { get; set; }

        [Required]
        [StringLength(50)]
        public string owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<countries> countries { get; set; }
    }
}
