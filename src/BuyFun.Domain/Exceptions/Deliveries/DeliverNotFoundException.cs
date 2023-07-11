namespace BuyFun.Domain.Exceptions.Deliveries;

public class DeliverNotFoundException : NotFoundException
{
    public DeliverNotFoundException()
    {
        this.TitleMessage = "Deliver not found";
    }

}
