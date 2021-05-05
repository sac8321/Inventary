using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace Business
{
   public class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputsList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateCategory(InputOutputEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInOut);
                db.SaveChanges();
            }
        }

        public void UpdateInOut(CategoryEntity uInOut)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(uInOut);
                db.SaveChanges();
            }
            
        }
    }
}
