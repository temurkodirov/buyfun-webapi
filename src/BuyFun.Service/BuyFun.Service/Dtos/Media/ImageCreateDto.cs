using Microsoft.AspNetCore.Http;

namespace BuyFun.Service.Dtos.Media;

public class ImageCreateDto
{
    public IFormFile File { get; set; } = default!;
}
