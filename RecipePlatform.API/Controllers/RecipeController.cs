using Microsoft.AspNetCore.Mvc;
using RecipePlatform.BLL.Interfaces;
using RecipePlatform.Models.Entities;

namespace RecipePlatform.API.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var recipes = await _recipeService.GetAllRecipesAsync();
            return Ok(recipes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var recipe = await _recipeService.GetRecipeByIdAsync(id);
            if (recipe == null) return NotFound();
            return Ok(recipe);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string term)
        {
            var results = await _recipeService.SearchRecipesAsync(term);
            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Recipe recipe)
        {
            await _recipeService.AddRecipeAsync(recipe);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Recipe recipe)
        {
            if (id != recipe.RecipeId) return BadRequest();
            await _recipeService.UpdateRecipeAsync(recipe);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _recipeService.DeleteRecipeAsync(id);
            return NoContent();
        }
    }
}
