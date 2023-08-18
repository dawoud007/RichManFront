using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ElectronicsShop_service.Models;

namespace ElectronicsShop_service.Dtos
{
    public class BillDto 
    {
        public Guid Id { get; set; }
        public string? BuyerName { get; set; }
        public string? SellerName { get; set; }
        public string? Description { get; set; }
        public MoneyAccountType AccountType { get; set; }

        public DateTime DateCreated { get; set; }
        public string? WorkerName { get; set; }
        public int SellingPricee { get; set; }
        public int ProfitDifference { get; set; }
        public string? WarningToNumberOfPieces { get; set; }

        public List<Cloth>? Suits { get; set; }
    }
	
}
