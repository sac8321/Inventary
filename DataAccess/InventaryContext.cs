using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<InputOutputEntity> InOuts { get; set; }

        public DbSet<WareHouseEntity> WareHouses { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-KGRG59C;Database=InventoryDb;User Id=sa;Password=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId="ASH",CategoryName="Aseo Hogar"},
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "PERFUME" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salus" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }

                );

            modelBuilder.Entity<WareHouseEntity>().HasData(
              new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega central", WareHouseAddress = "Costa Rica" },
                  new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega este", WareHouseAddress = "Panama" },
                      new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega oeste", WareHouseAddress = "Nicaragua"} 
                      
                );

        }

    }
}
