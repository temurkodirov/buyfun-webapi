using BuyFun.DataAccess.Common.Interfaces;
using BuyFun.Domain.Entities.Categories;

namespace BuyFun.DataAccess.Interfaces.Categories;

public interface ICategoryRepository:IRepository<Category,Category>, IGetAll<Category>
{

}
