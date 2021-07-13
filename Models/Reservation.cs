using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Reservation
    {
        [Key]
        [Required]
        public int ReservationId { get; set; }

        [MinLength(2, ErrorMessage = "Comment Must be at least 2 characters")]
        [Display(Name = "Comment")]
        public string Comment { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        [Display(Name = "Number of Adult")]
        public int numAdult { get; set; }
        [Display(Name = "Number of Child")]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed or 0")]
        public int numChild { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Check In")]
        public DateTime  FromDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Check Out")]
        public DateTime  ToDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public User ReservationBy { get; set; }
        public int ResortId { get; set; }
        public Resort ReservedIn { get; set; }
        public List<Booking> BookingInformation { get; set; }

        
    }
}