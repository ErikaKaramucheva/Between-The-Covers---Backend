using Between_The_Covers___Backend.DTO.Category;
using Between_The_Covers___Backend.Entities;
using Between_The_Covers___Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Between_The_Covers___Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromHeader] int categoryId)
        {
            var category= await _categoryService.DeleteCategory(categoryId);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDTO category)
        {
            var result = await _categoryService.AddCategory(category);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _categoryService.GetAllCategories();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById([FromHeader] int id)
        {
            var result = await _categoryService.GetCategoryById(id);
            return Ok(result);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetCategoryByName([FromBody] string name)
        {
            var result = await _categoryService.GetCategoryByName(name);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory([FromHeader] int id, [FromBody] Category category)
        {
            var result=await _categoryService.UpdateCategory(category, id);
            return Ok(result);
        }
    }
}
