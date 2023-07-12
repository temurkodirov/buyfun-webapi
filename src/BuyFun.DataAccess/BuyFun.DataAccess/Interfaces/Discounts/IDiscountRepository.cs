using BuyFun.DataAccess.Common.Interfaces;
using BuyFun.DataAccess.Utils;
using BuyFun.Domain.Entities.Discounts;

namespace BuyFun.DataAccess.Interfaces.Discounts;

public interface IDiscountRepository: IRepository<Discount, Discount>,
    IGetAll<Discount>
{
    public Task<IList<Discount>> GetAllByDurationAsync(DateTime startAt, DateTime endAt, PaginationParams @params);
}
