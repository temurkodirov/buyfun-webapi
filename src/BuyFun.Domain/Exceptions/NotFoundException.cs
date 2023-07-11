using System.Net;

namespace BuyFun.Domain.Exceptions;

public class NotFoundException
{
    public HttpStatusCode StatusCode { get; } = HttpStatusCode.NotFound;
    public string TitleMessage { get; protected set; } = string.Empty;
}
