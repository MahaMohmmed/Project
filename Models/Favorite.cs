using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Favorite
    {
        [Key]
        public int FavoriteId {set;get;}
        public int ResortId { get; set; }
        public Resort FavRes { get; set; }
        public int UserId { get; set; }
        public User FavoritesBy { get; set; }
    }
}