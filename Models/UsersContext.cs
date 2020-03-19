using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    
    public class UsersContext : DbContext
    {


        public UsersContext(DbContextOptions<UsersContext> options)
               : base(options)
        {
        }

        public DbSet<Users> User { get; set; }
    }
}
