using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipePlatform.DAL.Context;
using RecipePlatform.DAL.Interface;
using RecipePlatform.Models.Entities;

namespace RecipePlatform.DAL.Implementation
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IGenericRepository<Recipe> Recipes { get; private set; }
        public IGenericRepository<Category> Categories { get; private set; }
        public IGenericRepository<Rating> Ratings { get; private set; }
        public IGenericRepository<ApplicationUser> Users { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Recipes = new GenericRepository<Recipe>(_context);
            Categories = new GenericRepository<Category>(_context);
            Ratings = new GenericRepository<Rating>(_context);
            Users = new GenericRepository<ApplicationUser>(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
