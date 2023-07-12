using System.Net;

namespace BuyFun.Domain.Exceptions;

public class NotFoundException:Exception
{
    public HttpStatusCode StatusCode { get; } = HttpStatusCode.NotFound;
    public string TitleMessage { get; protected set; } = string.Empty;
}
