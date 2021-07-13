using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        // bring in Foreign Keys for both User and Resorts
        public int UserId { get; set; }
        public User bookedBy { get; set; }
        public int ResortId { get; set; }
        public Resort BookedResort { get; set; }
        public int ReservationId { get; set; }
        public Reservation ReservationInfo { get; set; }

    }
}