using Between_The_Covers___Backend.DTO.Category;
using Between_The_Covers___Backend.Entities;

namespace Between_The_Covers___Backend.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        public Task<Category> AddCategory(CreateCategoryDTO categoryDTO);
        public Task<bool> DeleteCategory(int categoryId);
        public Task<Category> GetCategoryById(int id);
        public Task<Category> GetCategoryByName(string name);
        public Task<Category> UpdateCategory(Category category, int categoryId);
        public Task<List<Category>>  GetAllCategories();
    }
}
