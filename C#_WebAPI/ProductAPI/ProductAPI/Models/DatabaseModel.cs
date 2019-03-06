using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductAPI.Models
{
    class DatabaseModel:DbContext
    {
        public DatabaseModel() : base("name=DefaultConnection")
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}