using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using UI.Models;
using UI.Data;

namespace Data
{
    public class DBInitalize : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Product.Add(new Product {Name = "Galaxy S8 Edge",Price = 500,CategoryId = 1 });

            context.Category.Add(new Category { Name = "Mobiles" });

            context.Category.Add(new Category {Name = "Cars" });

            base.Seed(context);

            context.SaveChanges();
        }
    }
}
