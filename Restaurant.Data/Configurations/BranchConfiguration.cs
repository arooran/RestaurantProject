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
    public class BranchConfiguration : EntityTypeConfiguration<Branch>
    {
        public BranchConfiguration()
        {
            HasKey(b => b.BranchId);
            Property(b => b.BranchId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(b => b.BranchName).IsRequired().HasMaxLength(512);
            Property(b => b.UniqueKey).IsRequired();
            Property(b => b.IsActive).IsRequired();
            Property(b => b.IsDeliveryEnabled).IsRequired();

            Property(b => b.CreatedDate).IsRequired();
            Property(b => b.CreatedBy).IsRequired();
            Property(b => b.ModifiedDate);
            Property(b => b.ModifiedBy);



            /* For branch address specification       
               One branch has only one address 1-to-1
               branch id should be a foreignkey for branch address
            */
            HasOptional(b => b.BranchAddress).WithRequired(a => a.Branch).WillCascadeOnDelete(true);



        }
    }
}
