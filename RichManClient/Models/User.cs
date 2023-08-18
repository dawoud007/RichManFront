using System.ComponentModel.DataAnnotations;

namespace ElectronicsShop_service.Models
{


  







    public class Shop 
	{

        public Guid Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? Role { get; set; }
        [Required]
        public string WhatToSee { get; set; }
        public DateTime CreationDate { get; set; }

        public List<Worker>? workUsers = new List<Worker>();
    }

    public class Worker
    {
        public int WorkerId { get; set; }
        public string? WorkerName { get; set; }
        public string? WhatToSee { get; set; }
    }

    public class MoneyUpdateDto
    {
        public MoneyAccountType AccountType { get; set; }

        public int Amount { get; set; }
        public string? ShopName { get; set; }
    }

    public class MoneyDeleteDto
    {
        public MoneyAccountType AccountType { get; set; }
        public int Amount { get; set; }
        public string WorkerName { get; set; }
        public string? ShopName { get; set; }
        public string DeleteReason { get; set; }
    }

    public enum MoneyAccountType
    {
        Box,
        Visa
    }

}
