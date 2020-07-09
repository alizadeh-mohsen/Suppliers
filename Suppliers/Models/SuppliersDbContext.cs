using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using SuppliersHub.Models;

namespace Suppliers.Models
{
    public class SuppliersDbContext:DbContext
    {
        public SuppliersDbContext():base("SuppliersDbContext")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Province> Provinces { get; set; }

    }
}