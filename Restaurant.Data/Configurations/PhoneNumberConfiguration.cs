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
    public class PhoneNumberConfiguration : EntityTypeConfiguration<PhoneNumbers>
    {
        public PhoneNumberConfiguration()
        {
            HasKey(p => p.PhoneNumberId);
            Property(p => p.PhoneNumberId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Number).IsRequired().HasMaxLength(100);
            HasRequired(p => p.PhoneNumberTypes).WithMany().Map(m => m.MapKey("PhoneNumberTypeId")).WillCascadeOnDelete(false);
            HasOptional(p => p.Branch).WithMany(b => b.PhoneNumbers).Map(m => m.MapKey("BranchId"));
          
        }
    }
}
