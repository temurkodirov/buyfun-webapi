using BuyFun.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BuyFun.Domain.Entities.Deliveries
{
    public class Deliver:Auditable
    {
        [MaxLength(13)]
        public string PhoneNumber { get; set; } = string.Empty;
        public bool PhoneNumberConfirmed { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public DateTime LastActivity { get; set; }
        public IdentityRole Role { get; set; }
    }
}
