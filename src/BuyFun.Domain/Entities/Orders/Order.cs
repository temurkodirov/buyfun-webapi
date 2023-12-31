﻿using BuyFun.Domain.Enums;

namespace BuyFun.Domain.Entities.Orders;

public class Order:Auditable
{
    public long UserId { get; set; }
    public long DeliverId { get; set; }
    public OrderStatus Status { get; set; }
    
    // The summ of order details result prices
    // The monay which that user must pay for products
    public double ProductsPrice { get; set; }
    public double DeliveryPrice { get; set; }
    
    //The payment that user must pay for sale
    //Products Price + Delivery Price
    public double ResultPrice { get; set; }

    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public PaymentType Payment { get; set; }
    public bool isPaid { get; set; }
    public bool isContracted { get; set; }
    public string Description { get; set; } = string.Empty;

}
