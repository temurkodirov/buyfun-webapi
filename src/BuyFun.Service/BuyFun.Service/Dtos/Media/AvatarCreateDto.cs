using Microsoft.AspNetCore.Http;

namespace BuyFun.Service.Dtos.Media;

public class AvatarCreateDto
{
    public IFormFile Avatar { get; set; } = default!;
}
