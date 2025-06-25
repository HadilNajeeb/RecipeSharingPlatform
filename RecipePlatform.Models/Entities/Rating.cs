using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipePlatform.Models.Entities
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int Value { get; set; }

        public string Comment { get; set; }
        public DateTime RatedAt { get; set; } = DateTime.Now;

        // Foreign Keys
        [Required]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
