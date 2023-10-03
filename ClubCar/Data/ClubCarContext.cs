using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClubCar.Models;

namespace ClubCar.Data
{
    public class ClubCarContext : DbContext
    {
        public ClubCarContext (DbContextOptions<ClubCarContext> options)
            : base(options)
        {
        }

        public DbSet<ClubCar.Models.Car> Car { get; set; } = default!;

        public DbSet<ClubCar.Models.Employee>? Employee { get; set; }
    }
}
