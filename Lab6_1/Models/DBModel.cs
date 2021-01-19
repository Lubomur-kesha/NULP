namespace Lab6_1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel2")
        {
        }

        public virtual DbSet<cities> cities { get; set; }
        public virtual DbSet<countries> countries { get; set; }
        public virtual DbSet<Restorants_chain> Restorants_chain { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cities>()
                .Property(e => e.city)
                .IsFixedLength();

            modelBuilder.Entity<cities>()
                .Property(e => e.country)
                .IsFixedLength();

            modelBuilder.Entity<countries>()
                .Property(e => e.country)
                .IsFixedLength();

            modelBuilder.Entity<countries>()
                .Property(e => e.restorant_chain)
                .IsFixedLength();

            modelBuilder.Entity<countries>()
                .Property(e => e.president)
                .IsFixedLength();

            modelBuilder.Entity<countries>()
                .HasMany(e => e.cities)
                .WithRequired(e => e.countries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restorants_chain>()
                .Property(e => e.restorant_chain)
                .IsFixedLength();

            modelBuilder.Entity<Restorants_chain>()
                .Property(e => e.country)
                .IsFixedLength();

            modelBuilder.Entity<Restorants_chain>()
                .Property(e => e.owner)
                .IsFixedLength();

            modelBuilder.Entity<Restorants_chain>()
                .HasMany(e => e.countries)
                .WithRequired(e => e.Restorants_chain)
                .WillCascadeOnDelete(false);
        }
    }
}
