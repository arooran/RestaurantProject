using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Branch : EntityBase
    {
        public Branch()
        {
            PhoneNumbers = new List<PhoneNumbers>();
        }
        public int BranchId { get; set; }
        public Guid UniqueKey { get; set; }
        public string BranchName { get; set; }      
        public bool IsDeliveryEnabled { get; set; }
        public double MaxDeliveryDistance { get; set; }
        public bool IsActive { get; set; }
        public int BranchAddressId { get; set; }
        public virtual BranchAddress BranchAddress { get; set; }
        public virtual ICollection<PhoneNumbers> PhoneNumbers { get; set; }
        
       
    }
}
