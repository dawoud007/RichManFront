using ElectronicsShop_service.Dtos;
using System.ComponentModel.DataAnnotations;

namespace RichMan.Models
{
    public class Money 

    {
        public int id { get; set; }
        public int MoneyInVisa { get; set; } = 0;
        public int MoneyInBox { get; set; } = 0;

        public string ShopName { get; set; }



        public void AddMoneyToVisa(int amount)
        {
            MoneyInVisa += amount;
        }

        public void AddMoneyToBox(int amount)
        {
            MoneyInBox += amount;
        }

        public void RemoveMoneyFromVisa(int amount)
        {
            MoneyInVisa -= amount;
        }

        public void RemoveMoneyFromBox(int amount)
        {
            MoneyInBox -= amount;
        }

        public void UpdateMoneyInVisa(int newAmount)
        {
            MoneyInVisa = newAmount;
        }

        public void UpdateMoneyInBox(int newAmount)
        {
            MoneyInBox = newAmount;
        }




    }


    public class DeleteReason
    {
        public int id { get; set; }
        public string ShopName { get; set; }
        public string workerName { get; set; }

        public int amount { get; set; }
        public string DeleteReasonDetails { get; set; }
        public DateTime DeleteData { get; set; } = DateTime.Now;
    }
}
