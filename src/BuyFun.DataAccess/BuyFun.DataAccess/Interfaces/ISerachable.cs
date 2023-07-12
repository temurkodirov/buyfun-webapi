using BuyFun.DataAccess.Utils;

namespace BuyFun.DataAccess.Interfaces;

public interface ISerachable<TModel>
{
    public Task<(int ItemsCount, IList<TModel>)> SearchAsync(string search, PaginationParams @params);
}
