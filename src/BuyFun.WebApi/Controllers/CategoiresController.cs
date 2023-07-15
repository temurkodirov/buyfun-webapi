using BuyFun.DataAccess.Utils;
using BuyFun.Service.Dtos.Categories;
using BuyFun.Service.Interfaces.Categories;
using Microsoft.AspNetCore.Mvc;

namespace BuyFun.WebApi.Controllers;

[Route("api/categories")]
[ApiController]
public class CategoiresController : ControllerBase
{
    private readonly ICategoryService _service;
    private readonly int maxPageSize = 30;
    public CategoiresController(ICategoryService service)
    {
        this._service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] int page = 1)
        => Ok(await _service.GetAllAsync(new PaginationParams(page, maxPageSize)));

    [HttpGet("{categoryId}")]
    public async Task<IActionResult> GetByIdAsync(long categoryId)
        => Ok();

    [HttpGet("count")]
    public async Task<IActionResult> CountAsync()
        => Ok(await _service.CountAsync());

    
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] CategoryCreateDto dto)
        => Ok(await _service.CreateAsync(dto));

    [HttpPut("{categoryId}")]
    public async Task<IActionResult> UpdateAsync (long categoryId, [FromForm] CategoryUpdateDto dto)
        =>Ok(await _service.UpdateAsync(categoryId,dto));

    [HttpDelete("{categoryId}")]
    public async Task<IActionResult> DeleteAsync(long categoryId)
        =>Ok(await _service.DeleteAsync(categoryId));
    
    #region Products
    [HttpGet("{categoryId}/products")]
    public async Task<IActionResult> GetProductsByCategoryIdAsync(long categoryId, [FromQuery] PaginationParams @params)
        => Ok(categoryId);
    #endregion  
}
