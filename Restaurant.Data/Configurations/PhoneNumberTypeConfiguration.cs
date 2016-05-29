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
    public class PhoneNumberTypeConfiguration : EntityTypeConfiguration<PhoneNumberTypes>
    {
        public PhoneNumberTypeConfiguration()
        {
            HasKey(p => p.PhoneNumberTypeId);
            Property(p => p.PhoneNumberTypeId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Description).IsRequired().HasMaxLength(128);
        }
    }
}
