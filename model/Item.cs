using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
	public class Item
	{
        public double ItemId { get; set; }
        public int ItemPrices { get; set; }
        public string ItemDescription { get; set; }
        public string ItemSellerName { get; set; }
        public string ItemAddress { get; set; }
        public int ItemContectNum { get; set; }
    }
}
