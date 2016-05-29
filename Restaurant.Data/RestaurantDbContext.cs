
using Restaurant.Data.Configurations;
using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("RestaurantDbContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            //Database.SetInitializer<MyMVCContext>(null);

        }

        public DbSet<Country> Country { get; set; }
        public DbSet<PhoneNumbers> PhoneNumber { get; set; }
        public DbSet<PhoneNumberTypes> PhoneNumberTypes { get; set; }
        public DbSet<AddressTypes> AddressTypes { get; set; }
        public DbSet<BranchAddress> Address { get; set; }
        public DbSet<Branch> Branch { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PhoneNumberTypeConfiguration());
            modelBuilder.Configurations.Add(new PhoneNumberConfiguration());
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new AddressTypeConfiguration());
            modelBuilder.Configurations.Add(new BranchAddressConfiguration());
            modelBuilder.Configurations.Add(new BranchConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
