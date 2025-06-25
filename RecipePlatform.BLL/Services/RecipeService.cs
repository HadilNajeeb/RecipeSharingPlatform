using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipePlatform.BLL.Interfaces;
using RecipePlatform.DAL.Interface;
using RecipePlatform.Models.Entities;

namespace RecipePlatform.BLL.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RecipeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Recipe>> GetAllRecipesAsync()
        {
            return await _unitOfWork.Recipes.GetAllAsync();
        }

        public async Task<Recipe> GetRecipeByIdAsync(int id)
        {
            return await _unitOfWork.Recipes.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Recipe>> SearchRecipesAsync(string term)
        {
            return await _unitOfWork.Recipes.FindAsync(r =>
                r.Title.Contains(term) || r.Description.Contains(term));
        }

        public async Task AddRecipeAsync(Recipe recipe)
        {
            await _unitOfWork.Recipes.AddAsync(recipe);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateRecipeAsync(Recipe recipe)
        {
            _unitOfWork.Recipes.Update(recipe);
            await _unitOfWork.CompleteAsync();
        }
        


        public async Task DeleteRecipeAsync(int id)
        {
            var recipe = await _unitOfWork.Recipes.GetByIdAsync(id);
            if (recipe != null)
            {
                _unitOfWork.Recipes.Delete(recipe);
                await _unitOfWork.CompleteAsync();
            }
        }
    }
}
