using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iscu_Paula_Lab8.Models;

namespace Iscu_Paula_Lab8.Data
{
    public class Iscu_Paula_Lab8Context : DbContext
    {
        public Iscu_Paula_Lab8Context (DbContextOptions<Iscu_Paula_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Iscu_Paula_Lab8.Models.Book> Book { get; set; }

        public DbSet<Iscu_Paula_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Iscu_Paula_Lab8.Models.Category> Category { get; set; }
    }
}
