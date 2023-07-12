namespace BuyFun.Domain.Exceptions.Files;

public class ImageNotFounException:NotFoundException
{
    public ImageNotFounException()
    {
        this.TitleMessage = "Image not Found";
    }
}
