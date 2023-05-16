using datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class SQLDbContext : DbContext
    {
        // Definir las propiedades DbSet para cada entidad en la base de datos
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(m => m.Email)
                .IsUnique();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = "Server=.;Database=SYSERP;User Id=sa;Password=abc123;";
            string connectionString = "Server=.;Database=SYSERP;Trusted_Connection=True;TrustServerCertificate=True";

            // Configurar la cadena de conexión a tu base de datos
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
