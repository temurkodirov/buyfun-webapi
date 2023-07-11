namespace BuyFun.Domain.Entities.Orders;

public class OrderDetail:Auditable
{
    public long OrderId { get; set; }   
    public long ProductId { get; set; }
    public int Quantity { get; set; }
   
    //Price of the products
    //Product price * quantity
    public int TotalPrice { get; set; }

    public double DiscountPrice { get; set; }
    
    //Price that user must pay for these products
    //TotalPrice - DisocuntPrice
    public double ResultPrice { get; set; }

}
