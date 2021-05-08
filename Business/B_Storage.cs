using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;


namespace Business
{
  public  class B_Storage
    {
        public List<StorageEntity> StoreList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        public static bool IsProductInWareHouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList().Where(s => s.StorageId == idStorage);

                return product.Any();
            }
        }

        public static List<StorageEntity> StorageProductsByWareHouse(string idWareHouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s=>s.Product)
                    .Include(s=>s.WareHouse)
                    .Where(s=>s.WareHouseId==idWareHouse)
                    .ToList();
            }
        }

        public static void UpdateStorage(StorageEntity uStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(uStorage);
                db.SaveChanges();
            }
        }


    }
}
