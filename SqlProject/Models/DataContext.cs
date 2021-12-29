using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlProject.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Counters> Counters { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<WhyUs> WhyUs { get; set; }

       
    }
}
