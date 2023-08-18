using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ElectronicsShop_service.Models;

namespace ElectronicsShop_service.Dtos
{
    public class StoreDto 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
		public List<Cloth> Suits { get; set; }
	}
}
