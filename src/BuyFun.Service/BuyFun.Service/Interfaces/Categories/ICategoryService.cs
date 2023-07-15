using BuyFun.DataAccess.Utils;
using BuyFun.Domain.Entities.Categories;
using BuyFun.Service.Dtos.Categories;

namespace BuyFun.Service.Interfaces.Categories;

public interface ICategoryService
{
    public Task<bool> CreateAsync(CategoryCreateDto dto);
    public Task<bool> DeleteAsync(long categoryId);
    public Task<long> CountAsync();
    public Task<IList<Category>> GetAllAsync(PaginationParams @params);
    public Task<Category> GetByIdAsync(long categoryId);
    public Task<bool> UpdateAsync(long categoryId, CategoryUpdateDto dto);
}
