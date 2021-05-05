using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
                    }
        }

        public static CategoryEntity CategoryById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList().LastOrDefault(p=>p.CategoryId==id);
            }
        }

        public static void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }        
        }

        public static void UpdateCategory(CategoryEntity uCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(uCategory);
                db.SaveChanges();
            }
        }

    }
}
