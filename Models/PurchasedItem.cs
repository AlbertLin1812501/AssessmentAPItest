using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class PurchasedItem
    {
        public double PurchasedItemId { get; set; }
        public double PurchasedItemPrices { get; set; }
        public string PurchasedItemDescription { get; set; }
        public string PurchasedItemSellerName { get; set; }
        public string PurchasedItemAddress { get; set; }
        public int PurchasedItemContectNum { get; set; }
    }
}
