using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labo07.Entities.Students;
using Microsoft.EntityFrameworkCore;

namespace Labo07.Context
{
    class UcaContext : DbContext//Server = locashost\\LAPTOP-00OSCEQ3;Database=db;Trusted_Connection=True;
    {
        public DbSet<Student> Students { get; set; }//LAPTOP-00OSCEQ3 Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=LAPTOP-00OSCEQ3;Database=ucadb;Trusted_Connection=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)//restricciones de nuestra base
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
