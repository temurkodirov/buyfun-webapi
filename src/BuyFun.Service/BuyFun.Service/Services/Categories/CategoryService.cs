using BuyFun.DataAccess.Interfaces.Categories;
using BuyFun.DataAccess.Utils;
using BuyFun.Domain.Entities.Categories;
using BuyFun.Domain.Exceptions.Categories;
using BuyFun.Domain.Exceptions.Files;
using BuyFun.Service.Common.Helpers;
using BuyFun.Service.Dtos.Categories;
using BuyFun.Service.Interfaces.Categories;
using BuyFun.Service.Interfaces.Common;

namespace BuyFun.Service.Services.Categories;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _repository;
    private readonly IFileService _fileService;
    public CategoryService(ICategoryRepository categoryRepository, 
        IFileService fileService)
    {
        this._repository = categoryRepository;
        this._fileService = fileService;
    }

    public async Task<long> CountAsync() => await _repository.CountAsync();

    public async Task<bool> CreateAsync(CategoryCreateDto dto)
    {
        string imagepath = await _fileService.UploadImageAsync(dto.Image);
        Category category = new Category()
        {
            ImagePath = imagepath,
            Name = dto.Name,
            Description = dto.Description,
            CreatedAt = TimeHelper.GetDateTime(),
            UpdatedAt = TimeHelper.GetDateTime()

        };
        var result = await _repository.CreateAsync(category);
        return result > 0;
    }

    public async Task<bool> DeleteAsync(long categoryId)
    {
        var category = await _repository.GetByIdAsync(categoryId);
        if (category is null) throw new CategoryNotFoundException();
        
        var result  = await _fileService.DeleteImageAsync(category.ImagePath);
        if (result == false) throw new ImageNotFoundException();

        var dbResult = await _repository.DeleteAsync(categoryId);
        return dbResult > 0;
    }



    public async Task<IList<Category>> GetAllAsync(PaginationParams @params)
    {
        var categories = await _repository.GetAllAsync(@params);
        return categories;
    }

    public async Task<Category> GetByIdAsync(long categoryId)
    {
        var category = await _repository.GetByIdAsync(categoryId);
        if (category is null) throw new CategoryNotFoundException();
        else return category;
    }

    /* public async Task<bool> UpdateAsyncy(long categoryId, CategoryUpdateDto dto)
     {
         var category = await _repository.GetByIdAsync(categoryId);
         if (category is null) throw new CategoryNotFoundException();

         //parse new items to category
         category.Name = dto.Name;
         category.Description = dto.Description;

         if(dto.Image is not null)
         {
             // delete last image
             var deleteResult = await _fileService.DeleteImageAsync(category.ImagePath);
             if (deleteResult is false) throw new ImageNotFoundException();

             // upload new image
             string newImagePath = await _fileService.UploadImageAsync(dto.Image);

             //parse new path to category
             category.ImagePath = newImagePath;
         }
         //else category old image have to save

         category.UpdatedAt = TimeHelper.GetDateTime();

         var dbResult = await _repository.UpdateAsync(categoryId, category);
         return dbResult > 0;

     }*/

    public async Task<bool> UpdateAsync(long categoryId, CategoryUpdateDto dto)
    {
        var category = await _repository.GetByIdAsync(categoryId);
        if (category is null) throw new CategoryNotFoundException();

        // parse new items to category
        category.Name = dto.Name is null ? category.Name: dto.Name;
        category.Description = dto.Description;

        if (dto.Image is not null)
        {
            // delete old image
            var deleteResult = await _fileService.DeleteImageAsync(category.ImagePath);
            if (deleteResult is false) throw new ImageNotFoundException();

            // upload new image
            string newImagePath = await _fileService.UploadImageAsync(dto.Image);

            // parse new path to category
            category.ImagePath = newImagePath;
        }
        // else category old image have to save

        category.UpdatedAt = TimeHelper.GetDateTime();

        var dbResult = await _repository.UpdateAsync(categoryId, category);
        return dbResult > 0;
    }

}
