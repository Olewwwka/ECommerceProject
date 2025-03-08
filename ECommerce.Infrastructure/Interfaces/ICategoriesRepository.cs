using ECommerce.Infrastructure.Entities;

namespace ECommerce.Infrastructure.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<int> Create(CategoryEntity category);
        Task<int> Delete(int id);
        Task<List<CategoryEntity>> GetAll();
        Task<CategoryEntity?> GetByIdAsync(int id);
        Task<int> Update(int id, string name, string description);
    }
}