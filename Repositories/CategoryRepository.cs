using Between_The_Covers___Backend.DTO.Category;
using Between_The_Covers___Backend.Entities;
using Between_The_Covers___Backend.Repositories.Interfaces;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace Between_The_Covers___Backend.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BooksBlogDbContext _dbContext;
        public CategoryRepository(BooksBlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Category> AddCategory(CreateCategoryDTO categoryDTO)
        {
            Category category = new Category();
            category.Name = categoryDTO.Name;
            category.Id = categoryDTO.Id;
            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<bool> DeleteCategory(int categoryId)
        {
            var currentCategory = await _dbContext.Categories.FindAsync(categoryId);
            if (currentCategory == null)
            {
                return false;
            }
            _dbContext.Categories.Remove(currentCategory);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            var result = await _dbContext.Categories.ToListAsync();
            return result;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _dbContext.Categories.FindAsync(id);
            
        }

        public async Task<Category> GetCategoryByName(string name)
        {
            var result= await _dbContext.Categories.FirstOrDefaultAsync(r=>r.Name.ToLower().Equals(name.ToLower()));
            return result;
        }

        public async Task<Category> UpdateCategory(Category category, int categoryId)
        {
            var currentCategory = await _dbContext.Categories.FindAsync(categoryId);
            if (currentCategory == null)
            {
                return null;
            }
            else
            {
                currentCategory.Name = category.Name;
                
            }
            await _dbContext.SaveChangesAsync();
            return currentCategory;

        }
    }
}