using Microsoft.AspNetCore.Mvc;
using RecipePlatform.Models.Entities;
using RecipePlatform.Models.Enum;

namespace RecipePlatform.MVC.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            // بيانات تجريبية فقط لعرض القائمة
            var recipes = GetDummyRecipes();
            return View(recipes);
        }

        public IActionResult Details(int id)
        {
            var recipe = GetDummyRecipes().FirstOrDefault(r => r.RecipeId == id);
            if (recipe == null)
                return NotFound();

            return View(recipe);
        }

        private List<Recipe> GetDummyRecipes()
        {
            return new List<Recipe>
            {
                new Recipe {
                    RecipeId = 1,
                    Title = "Spaghetti Bolognese",
                    Description = "A classic Italian pasta dish.",
                    Ingredients = "Pasta, minced meat, tomatoes",
                    Instructions = "Cook pasta. Cook meat. Mix with sauce.",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 30,
                    Servings = 4,
                    Difficulty = DifficultyLevel.Medium,
                    Category = new Category { CategoryId = 1, Name = "Main Dishes" },
                    ApplicationUser = new ApplicationUser { UserName = "chef_ali" }
                },
                new Recipe {
                    RecipeId = 2,
                    Title = "Chocolate Cake",
                    Description = "Delicious rich chocolate cake.",
                    Ingredients = "Flour, cocoa, eggs, sugar",
                    Instructions = "Mix ingredients. Bake at 180C for 40 minutes.",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 40,
                    Servings = 8,
                    Difficulty = DifficultyLevel.Hard,
                    Category = new Category { CategoryId = 2, Name = "Desserts" },
                    ApplicationUser = new ApplicationUser { UserName = "chef_lama" }
                }
            };
        }
    }
}