using System.ComponentModel.DataAnnotations;

namespace BuyFun.Domain.Entities.Suppliers;

public class Supplier:Auditable
{
    [MaxLength(50)]
    public string CompanyName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    [MaxLength(13)]
    public string FaxPhoneNumber { get; set; }
    [MaxLength(13)]
    public string ContactPhoneNumber { get; set; }

}
