using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace AutoPartsProject.Models
{
    public class PartsContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public PartsContext(DbContextOptions<PartsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
