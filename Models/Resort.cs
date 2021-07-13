using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Resort
    {
        [Key]
        [Required]
        public int ResortId { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Must be at least 3 characters")]
        public string Name { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "Must be at least 10 characters")]
        [Display(Name = "Image URL")]
        public string ImgUrl { get; set; }
        [Display(Name = "Img URL (Optional)")]
        public string ImgUrl2 { get; set; }
        [Display(Name = "Img URL (Optional)")]

        public string ImgUrl3 { get; set; }

        //address
        [Required]
        public string Latitude { get; set; }

        [Required]
        public string Longitude { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed or 0")]
         public decimal Price  { get; set; }

         [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed or 0")]
         public int Limit  { get; set; }

         [Required]
        [Range(0, 6, ErrorMessage = "only from 0 to 5")]
        [Display(Name = "Stars")]
        public int Rate  { get; set; } 
    
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        // Foreign Key for UserId has to match the property name in User class
        public int UserId { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public User PostedBy { get; set; }
        public List<Booking> Visitors { get; set; }
        public List<Favorite> FavList { get; set; }

        public List <Review> ResReviews { get; set; }

    }
}