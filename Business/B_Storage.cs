using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;


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

        public void UpdateStorage(StorageEntity uStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(uStorage);
                db.SaveChanges();
            }
        }


    }
}
