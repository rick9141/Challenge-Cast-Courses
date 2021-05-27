using CastCourses.Domain.Entities;
using CastCourses.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastCourses.Infra.Data.Context
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=DESKTOP-HVNTI80\\DESENVOLVIMENTO;Initial Catalog=DDD_ECOMMERCE;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }
    }
}
