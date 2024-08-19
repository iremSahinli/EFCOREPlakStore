using Microsoft.EntityFrameworkCore;
using Plak_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_DAL.Context
{
    public class AppDbContext : DbContext
    {

        public DbSet<Album> Albums { get; set; }
        public DbSet<Admin> Admins { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-H6KLH85\SQLEXPRESS;Initial Catalog=StorePlak_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

    }
}
