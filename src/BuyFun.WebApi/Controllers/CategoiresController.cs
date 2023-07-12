using BuyFun.Service.Dtos.Categories;
using BuyFun.Service.Interfaces.Categories;
using Microsoft.AspNetCore.Mvc;

namespace BuyFun.WebApi.Controllers;

[Route("api/categories")]
[ApiController]
public class CategoiresController : ControllerBase
{
    private readonly ICategoryService _service;
    public CategoiresController(ICategoryService service)
    {
        this._service = service;
    }
    [HttpGet]
    public async Task<IActionResult> CountAsync()
        =>Ok(await _service.CountAsync()); 

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] CategoryCreateDto dto)
        => Ok(await _service.CreateAsync(dto));

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(long categoryId)
        =>Ok(await _service.DeleteAsync(categoryId));
}
  