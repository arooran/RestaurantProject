using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Restaurant.Data.Configurations
{
    class BranchAddressConfiguration : EntityTypeConfiguration<BranchAddress>
    {
        public BranchAddressConfiguration()
        {
            HasKey(a => a.BranchAddressId);
            Property(a => a.BranchAddressId).IsRequired();
            Property(a => a.BuildingNumber).HasMaxLength(256);
            Property(a => a.City).HasMaxLength(128);
            Property(a => a.UniqueKey).IsRequired();
            Property(b => b.CreatedDate).IsRequired();
            Property(b => b.CreatedBy).IsRequired();
            Property(b => b.CreatedDate).IsRequired();
            Property(b => b.CreatedBy).IsRequired();
            Property(b => b.ModifiedDate);
            Property(b => b.ModifiedBy);

            HasOptional(a => a.Country).WithMany().Map(m => m.MapKey("CountryId")).WillCascadeOnDelete(false);
           
                
        }
    }
}
