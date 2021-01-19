namespace Lab6_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cities
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int city_id { get; set; }

        [Key]
        [StringLength(50)]
        public string city { get; set; }

        [Required]
        [StringLength(50)]
        public string country { get; set; }

        public int area_km_kv { get; set; }

        public virtual countries countries { get; set; }
    }
}
