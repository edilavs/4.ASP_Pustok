using Microsoft.EntityFrameworkCore;
using Pustok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
