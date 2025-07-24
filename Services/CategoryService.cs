using Between_The_Covers___Backend.DTO.Category;
using Between_The_Covers___Backend.Entities;
using Between_The_Covers___Backend.Repositories.Interfaces;
using Between_The_Covers___Backend.Services.Interfaces;

namespace Between_The_Covers___Backend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<Category> AddCategory(CreateCategoryDTO c)
        {
           return await _categoryRepository.AddCategory(c);
        }

        public async Task<bool> DeleteCategory(int id)
        {
            return await (_categoryRepository.DeleteCategory(id));
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await _categoryRepository.GetAllCategories();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryRepository.GetCategoryById(id);
        }

        public async Task<Category> GetCategoryByName(string name)
        {
            return await _categoryRepository.GetCategoryByName(name);
        }

        public async Task<Category> UpdateCategory(Category c, int id)
        {
            return await(_categoryRepository.UpdateCategory(c, id));
        }
    }
}
