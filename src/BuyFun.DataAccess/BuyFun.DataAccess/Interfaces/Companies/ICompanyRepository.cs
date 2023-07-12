using BuyFun.DataAccess.Common.Interfaces;
using BuyFun.Domain.Entities.Companies;

namespace BuyFun.DataAccess.Interfaces.Companies;

public interface ICompanyRepository: IRepository<Company,Company>, IGetAll<Company>
{

}
