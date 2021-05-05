using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
  public  class B_WareHouse
    {
        public static List<WareHouseEntity> WareHouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.WareHouses.ToList();
            }
        }

        public static WareHouseEntity WareHouseById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.WareHouses.ToList().LastOrDefault(p=>p.WareHouseId==id);
            }
        }

        public static void CreateWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Add(oWareHouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWareHouse(WareHouseEntity uWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Update(uWareHouse);
                db.SaveChanges();
            }
        }

    }
}
