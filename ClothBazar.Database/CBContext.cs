using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothBazar.Entities;
using Microsoft.Build.Framework.XamlTypes;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace ClothBazar.Database
{
    class CBContext : DbContext
    {
        public CBContext() : base("ClothBazarConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
