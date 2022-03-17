using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exam2.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(): base("name=ConnectionString")
         {

         }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        
    }
}