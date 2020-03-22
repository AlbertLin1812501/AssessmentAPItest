using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models 
{ 
public class ItemCon : DbContext
{
	public ItemCon(DbContextOptions<UsersContext> options) : base(options)
    {
	}
		public DbSet<Item> Item { get; set; }
	}
}
