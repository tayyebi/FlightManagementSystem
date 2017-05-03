namespace FlightManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Line")]
    public partial class Line
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Line()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FromCity { get; set; }

        [Required]
        [StringLength(50)]
        public string FromAirport { get; set; }

        [Required]
        [StringLength(50)]
        public string ToCity { get; set; }

        [Required]
        [StringLength(50)]
        public string ToAirport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
