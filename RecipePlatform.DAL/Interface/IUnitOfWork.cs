using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipePlatform.Models.Entities;

namespace RecipePlatform.DAL.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Recipe> Recipes { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Rating> Ratings { get; }
        IGenericRepository<ApplicationUser> Users { get; }

        Task<int> CompleteAsync();
    }
}

