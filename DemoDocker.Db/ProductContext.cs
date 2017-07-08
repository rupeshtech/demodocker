using DemoDocker.Db.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDocker.Db
{
    public class ProductContext:DbContext
    {
        public ProductContext() : base() { }
        public ProductContext(string connString)
        : base(connString)
    {
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Product>().HasKey(p => p.Id);
        }
    }
}
