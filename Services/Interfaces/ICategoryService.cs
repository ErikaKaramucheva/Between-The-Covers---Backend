using Between_The_Covers___Backend.DTO.Category;
using Between_The_Covers___Backend.Entities;

namespace Between_The_Covers___Backend.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        Task<Category> GetCategoryByName(string name);
        Task<Category> AddCategory(CreateCategoryDTO c);
        Task<Category> UpdateCategory(Category c, int id);
        Task<bool> DeleteCategory(int id);
    }
}
