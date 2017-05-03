namespace FlightManagementSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MainModel : DbContext
    {
        public MainModel()
            : base("name=MainModel")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(e => e.Planes)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Line>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Line)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plane>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Plane)
                .WillCascadeOnDelete(false);
        }
    }
}
