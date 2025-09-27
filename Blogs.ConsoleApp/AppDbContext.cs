using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Blogs.ConsoleApp.Models;

namespace Blogs.ConsoleApp
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                string connectionString = "Server=.;Database=TrainingBatch5;User Id=sa;Password=23032106;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);          
            }
        }

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}