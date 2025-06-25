using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;

namespace RecipePlatform.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Recipe> Recipes { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
