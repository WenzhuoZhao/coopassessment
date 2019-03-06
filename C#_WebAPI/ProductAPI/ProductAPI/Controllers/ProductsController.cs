using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductAPI.Controllers
{
    public class ProductsController : ApiController
    {
        DatabaseModel dbContext = new DatabaseModel();

        public Product Get(int id)
        {
            var product = dbContext.Product.Where(x => x.ID == id).FirstOrDefault();
            if(product != null)
            {
                return product;
            }
            return null;
        }


        public List<Product> GetAll()
        {
            return dbContext.Product.ToList();
        }

        [HttpPost]
        public void Delete(int id)
        {
            var product = dbContext.Product.Where(x => x.ID == id).FirstOrDefault();

            if(product != null)
            {
                dbContext.Product.Remove(product);
                dbContext.SaveChanges();
            }
        }

        public void Add(Product product)
        {
           dbContext.Product.Add(product);
           dbContext.SaveChanges();
        }

        public string Edit(Product product)
        {
            Product findProduct = dbContext.Product.Where(x => x.ID == product.ID).FirstOrDefault();
            if(product != null)
            {
                product.Name = product.Name + "_editted";
                product.Price = product.Price;
                product.Description = product.Description;
                dbContext.SaveChanges();
                return "Successfully Changed";
            }
            else
            {
                return "Not Found";
            }
        }
    }
}
