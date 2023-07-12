using BuyFun.DataAccess.Common.Interfaces;
using BuyFun.DataAccess.ViewModels.Deliveries;
using BuyFun.Domain.Entities.Deliveries;

namespace BuyFun.DataAccess.Interfaces.Deliveries;

public interface IDeliveryRepository :IRepository<Deliver, Deliver>,
    IGetAll<DeliverViewModel>
{
    public Task<DeliverViewModel> GetDeliverAsync(long id);
}
