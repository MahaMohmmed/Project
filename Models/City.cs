using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        // bring in Foreign Keys for both User and Resorts
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        public List<Resort> CityResorts { get; set; }


        
    }
}