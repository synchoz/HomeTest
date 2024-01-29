using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeTest.Models;

namespace HomeTest.Data
{
    public class HomeTestContext : DbContext
    {
        public HomeTestContext (DbContextOptions<HomeTestContext> options)
            : base(options)
        {
        }

        public DbSet<HomeTest.Models.City> City { get; set; } = default!;
    }
}
