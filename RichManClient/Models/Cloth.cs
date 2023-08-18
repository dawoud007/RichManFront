using System.ComponentModel.DataAnnotations;

namespace ElectronicsShop_service.Models
{
	public class Cloth
	{ 
        public Guid Id { get; set; }

        public Cloth() { }
        [Required]
        public string Name { get; set; }

        public string? type { get; set; }
        [Required]
        public int Size { get; set; }

        [Required]
        public string Color { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 0.")]
        public int NumOfPieces { get; set; }

        public string? StoreName { get; set; }

        public int? limit { get; set; } = 10;
        public int Gomla { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string? Note { get; set; } = "";

        public Guid? BillId { get; set; }


    }
}
