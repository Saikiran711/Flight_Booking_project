﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Booking_project.Domain.Entities
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public bool IsPaid { get; set; }

        // Each booking is associated with one user
        public int UserId { get; set; }
        public User User { get; set; }

        //booking have multiple passengers
        public ICollection<Passenger> Passengers { get; set; }

        // Each booking is associated with a flight
        public int FlightId { get; set; }
        public Flight Flight { get; set; }

    }
}
