using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]

        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string Confirm { get; set; }
        // Navigation property for related Movie and Like objects
        public List<Resort> PostedResorts { get; set; }
        public List<Booking> VisitedResort { get; set; }
        public List<Reservation> MyReservation { get; set; }
        public List<Favorite> FavResorts { get; set; }
        public List <Review> MyReviews { get; set; }
        

    }
}