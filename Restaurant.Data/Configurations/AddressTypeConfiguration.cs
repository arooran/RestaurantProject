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
    public class AddressTypeConfiguration : EntityTypeConfiguration<AddressTypes>
    {
        public AddressTypeConfiguration()
        {
            HasKey(a => a.AddressTypeId);
            Property(a => a.AddressTypeId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Description).IsRequired().HasMaxLength(512);

            Property(b => b.CreatedDate).IsRequired();
            Property(b => b.CreatedBy).IsRequired();
            Property(b => b.ModifiedDate);
            Property(b => b.ModifiedBy);
        }
    }
}
