using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVCAPI.Models;

namespace SalesWebMVCAPI.Data
{
    public class SalesWebMVCAPIContext : DbContext
    {
        public SalesWebMVCAPIContext (DbContextOptions<SalesWebMVCAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMVCAPI.Models.Department> Department { get; set; }
    }
}
