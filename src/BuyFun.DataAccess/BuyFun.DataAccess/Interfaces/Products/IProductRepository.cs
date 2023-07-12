using BuyFun.DataAccess.Common.Interfaces;
using BuyFun.DataAccess.ViewModels.Products;
using BuyFun.Domain.Entities.Products;

namespace BuyFun.DataAccess.Interfaces.Products;

public interface IProductRepository: IRepository<Product, ProductViewModel>,
    IGetAll<ProductViewModel>,ISerachable<ProductViewModel>
{

}
