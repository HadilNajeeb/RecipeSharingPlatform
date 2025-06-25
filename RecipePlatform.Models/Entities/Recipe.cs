using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipePlatform.Models.Enum;

namespace RecipePlatform.Models.Entities
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        public string Instructions { get; set; }

        public int PrepTimeMinutes { get; set; }
        public int CookTimeMinutes { get; set; }
        public int Servings { get; set; }
        public DifficultyLevel Difficulty { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Foreign Keys
        [Required]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Navigation
        public ICollection<Rating> Ratings { get; set; }

    }
}