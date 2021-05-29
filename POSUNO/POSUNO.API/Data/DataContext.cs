using Microsoft.EntityFrameworkCore;
using POSUNO.API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSUNO.API.Data
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// conecion Bd
        /// </summary>
        /// <param name="options"></param>
       public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        ////propiedades por clase o tabla
        ///
        public DbSet<Product>  Products { get; set; }
        public DbSet<User>Users { get; set; }
        /// <summary>
        /// crear el modelo de bd
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //indice unico
            modelBuilder.Entity<Product>().HasIndex(p => p.Name).IsUnique();
            modelBuilder.Entity<User>().HasIndex(p => p.Email).IsUnique();


        }
    }
}
