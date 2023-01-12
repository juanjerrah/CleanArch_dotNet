using Domain.Product.Entities;

namespace Domain.Product.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetCategories();
    Task<Category?> GetCategoryById(Guid? id);
    Task<Category> CreateCategory(Category Category);
    Task<Category> UpdateCategory(Category Category);
    Task<Category> DeleteCategory(Category Category);
}