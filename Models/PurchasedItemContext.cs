using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
	public class PurchasedItemContext : DbContext
	{
		public PurchasedItemContext(DbContextOptions<PurchasedItemContext> options) : base(options)
		{
		}
		public DbSet<PurchasedItem> PruchasedItems { get; set; }
	}
}
