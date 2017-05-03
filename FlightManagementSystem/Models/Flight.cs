namespace FlightManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Flight
    {
        public int Id { get; set; }

        public int LineId { get; set; }

        public DateTime TakeOfMoment { get; set; }

        public DateTime LandingMoment { get; set; }

        public int Passengers { get; set; }

        [Required]
        [StringLength(50)]
        public string Stauts { get; set; }

        public short? LandingAirportRunawayNumber { get; set; }

        public short? LandingAirportRunawayNumberHost { get; set; }

        public int PlaneId { get; set; }

        public virtual Line Line { get; set; }

        public virtual Plane Plane { get; set; }
    }
}
