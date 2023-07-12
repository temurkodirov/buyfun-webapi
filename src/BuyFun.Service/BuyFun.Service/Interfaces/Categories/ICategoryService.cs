using BuyFun.Service.Dtos.Categories;

namespace BuyFun.Service.Interfaces.Categories;

public interface ICategoryService
{
    public Task<bool> CreateAsync(CategoryCreateDto dto);
    public Task<bool> DeleteAsync(long categoryId);
    public Task<long> CountAsync();
}
