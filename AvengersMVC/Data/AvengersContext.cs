using AvengersMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvengersMVC.Data
{
    public class AvengersContext : DbContext
    {
        public AvengersContext(DbContextOptions<AvengersContext> options) : base(options)
        {
        }

        public DbSet<Avenger> Avengers { get; set; }
    }
}
