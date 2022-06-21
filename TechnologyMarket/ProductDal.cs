using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyMarket
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ShopingContext context = new ShopingContext())
            {
               return context.Products.ToList();
            }
        }
        public List<Product> GetByName(string key)
        {
            using (ShopingContext context = new ShopingContext())
            {
                return context.Products.Where(p => p.PRODUCTNAME.Contains(key)).ToList();
            }
        }
        
        public void Add(Product product)
        {
            using (ShopingContext context = new ShopingContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (ShopingContext context = new ShopingContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Deleted(Product product)
        {
            using (ShopingContext context = new ShopingContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
